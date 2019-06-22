using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;


namespace BeerQuest.Controllers
{
    public class MembersController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;

        public MembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            if (TempData["wrongPin"] != null)
            {
                ViewBag.WrongPin = TempData["wrongPin"].ToString();
            }
            var loggedInMember = GetLoggedInMember();
            loggedInMember = GetRank(loggedInMember);
            return View(loggedInMember);
        }

        // GET: Members/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // GET: Members/Create
        public IActionResult Create()
        {
            Member member = new Member();
            return View(member);
        }

        // POST: Members/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name")] Member member)
        {
            if (ModelState.IsValid)
            {
                var userId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
                member.ApplicationId = userId;
                _context.Add(member);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Members/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members.FindAsync(id);
            if (member == null)
            {
                return NotFound();
            }
            return View(member);
        }

        // POST: Members/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name")] Member member)
        {
            if (id != member.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(member);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MemberExists(member.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(member);
        }

        // GET: Members/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var member = await _context.Members
                .FirstOrDefaultAsync(m => m.Id == id);
            if (member == null)
            {
                return NotFound();
            }

            return View(member);
        }

        // POST: Members/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.Members.FindAsync(id);
            _context.Members.Remove(member);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MemberExists(int id)
        {
            return _context.Members.Any(e => e.Id == id);
        }

        public ActionResult CustomerPassport()
        {
            Passport passport;
            passport = CreatePassport();
            _context.Passports.Add(passport);
            _context.SaveChanges();
            int id = passport.Id;
            var loggedInMember = GetLoggedInMember();
            loggedInMember.ActivePassport = true;
            loggedInMember.PassportId = id;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public Passport CreatePassport()
        {
            var potentialStops = _context.Businesses.ToList();
            Passport passport = new Passport();
            ChooseStop(potentialStops, passport, 1, true);
            ChooseStop(potentialStops, passport, 2, false);
            ChooseStop(potentialStops, passport, 3, false);
            ChooseStop(potentialStops, passport, 4, true);
            passport.CurrentStop = 1;
            passport.StartDate = DateTime.Today;
            passport.StopDate = DateTime.Today.AddDays(7);
            _context.SaveChanges();
            return passport;
        }

        public void ChooseStop(List<Business> list, Passport passport, int stopNumber, bool premium)
        {
            var stop = new Stop();
            int total = list.Count();
            Random r = new Random();
            int offset = r.Next(0, total);
            if (premium == true)
            {
                var newStop = list.Skip(offset).FirstOrDefault();
                while (newStop.Premium == false)
                {
                    offset = r.Next(0, total);
                    newStop = list.Skip(offset).FirstOrDefault();
                }
                stop.BusinessID = newStop.Id;
                list.Remove(newStop);
            }
            else
            {
                var newStop = list.Skip(offset).FirstOrDefault();
                list.Remove(newStop);
                stop.BusinessID = newStop.Id;
            }
            _context.Add(stop);
            _context.SaveChanges();
            int id = stop.Id;
            switch (stopNumber)
            {
                case 1:
                    passport.StopOneId = id;
                    break;
                case 2:
                    passport.StopTwoId = id;
                    break;
                case 3:
                    passport.StopThreeId = id;
                    break;
                case 4:
                    passport.StopFourId = id;
                    break;
                case 5:
                    passport.StopFiveId = id;
                    break;
            }
            _context.SaveChanges();
        }

        public void CreateFifthStop(Passport passport)
        {
            var potentialFifth = _context.Businesses.Where(b => b.CheckIns > 10).ToList();
            ChooseStop(potentialFifth, passport, 5, false);
            passport.StopFive.IsFree = true;
            _context.SaveChanges();
        }

        public ActionResult pincheck(int stop, int pin)
        {
            Stop currentStop;
            var loggedInMember = GetLoggedInMember();
            switch (stop)
            {
                case 1:
                    currentStop = loggedInMember.Passport.StopOne;
                    break;
                case 2:
                    currentStop = loggedInMember.Passport.StopTwo;
                    break;
                case 3:
                    currentStop = loggedInMember.Passport.StopThree;
                    break;
                case 4:
                    currentStop = loggedInMember.Passport.StopFour;
                    break;
                case 5:
                    currentStop = loggedInMember.Passport.StopFive;
                    break;
                default:
                    currentStop = loggedInMember.Passport.StopOne;
                    break;
            }
            if (pin == currentStop.Business.Pin)
            {
                TempData["wrongPin"] = null;
                currentStop.Complete = true;
                currentStop.Business.CheckIns++;
                _context.SaveChanges();
                StopCheck(loggedInMember.Passport, currentStop);
                if (loggedInMember.Passport.CurrentStop == 5)
                {
                    return RedirectToAction(nameof(FreeBeerMap));
                }
                else
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                TempData["wrongPin"] = "Incorrect Pin, try again.";
                return RedirectToAction(nameof(Index));
            }
        }

        public void StopCheck(Passport passport, Stop stop)
        {
            var member = GetLoggedInMember();
            CreateMessage(stop, member);
            if (passport.CurrentStop < 4)
            {
                passport.CurrentStop++;
                member.Points = +5;
                _context.SaveChanges();
            }
            else if (passport.CurrentStop == 4)
            {
                CreateFifthStop(passport);
                passport.CurrentStop++;
                member.Points = +5;
                _context.SaveChanges();

            }
            else if (passport.CurrentStop == 5)
            {
                FreeBeer(member, passport, stop);
                passport.CurrentStop++;
                member.Points = +10;
                member.ActivePassport = false;
                _context.SaveChanges();
            }
        }
        public List<Message> GetMesssageList()
        {
            var messageList = _context.Messages.ToList();
            return messageList;
        }
        public void CreateMessage(Stop stop, Member member)
        {
            Message message = new Message();
            DateTime now = DateTime.Now;
            message.CurrentRank = member.Title;
            message.CurrentBar = stop.Business.Name;
            var business = _context.Businesses.First(m => m.Name == stop.Business.Name);
            CheckFreeEligibility(business);
            message.CurrentDay = now;
            message.CurrentMember = member.Name;
            message.WasFree = stop.IsFree;
            _context.Messages.Add(message);
            _context.SaveChanges();
        }
        public void CheckFreeEligibility(Business business)
        {
            business.CheckIns++;
            //check thatbusinesses eligibility
            if (business.CheckIns > 10)
            {
                //business.FreeBeerEligibilitybool = true; //display eligibility in view
            }
            else
            {
                //business.FreeBeerEligibility = false;
            }
        }

        public Member GetLoggedInMember()
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInMember = _context.Members.Include(m => m.Passport).ThenInclude(p => p.StopOne).ThenInclude(s => s.Business).Include(m => m.Passport).ThenInclude(p => p.StopTwo).ThenInclude(s => s.Business).Include(m => m.Passport).ThenInclude(p => p.StopThree).ThenInclude(s => s.Business).Include(m => m.Passport).ThenInclude(p => p.StopFour).ThenInclude(s => s.Business).Include(m => m.Passport).ThenInclude(p => p.StopFive).ThenInclude(s => s.Business).Single(b => b.ApplicationId == currentUserId);
            return loggedInMember;
        }

        public void FreeBeer(Member member, Passport passport, Stop stop)
        {
            //var member = _context.Members
            //    .FirstOrDefaultAsync(m => m.Id == id);
            if (member.ActivePassport == true && passport.CurrentStop == 5)
            {
                stop.IsFree = true;
            }
        }
        public async Task<IActionResult> FreeBeerMap()
        {
            var loggedInMember = GetLoggedInMember();
            return View(loggedInMember);
        }

        public List<Message> GetMemberMessages()
        {
            List<Message> message = _context.Messages.ToList();
            message.Reverse();

            for (int i = (message.Count - 1); i >= 19; i--)
            {
                message.Remove(message[i]);
            }


            return message;

        }
        public async Task<IActionResult> SeeMemberMessages()
        {
            return View(GetMemberMessages());
        }


        public async Task<IActionResult> Rank()
        {
            var rank = _context.Ranks.ToList();
            return View(rank);
        }


        public Member GetRank(Member member)
        {
            string currentTitle;
            if (member.Points > 1599)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 10).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 1199)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 9).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 899)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 8).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 649)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 7).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 449)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 6).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 299)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 5).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 174)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 4).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 74)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 3).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points > 29)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 2).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            if (member.Points >= 0)
            {
                Rank rank = _context.Ranks.Where(c => c.Id == 1).Single();
                currentTitle = rank.Name;
                member.Title = currentTitle;
                _context.SaveChanges();
                return member;
            }
            return member;
        }

    }
}

//TODO: Incorrect Pin Message
// 5th stop