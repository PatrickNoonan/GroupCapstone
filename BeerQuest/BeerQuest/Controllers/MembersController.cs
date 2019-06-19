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
    //This currently pulls a list of all the members. We want it to only function for a single user.
    public class MembersController : Controller
    {
        private readonly ApplicationDbContext _context;
        //private UserManager<ApplicationUser> _userManager;
        //private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public MembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Members
        public async Task<IActionResult> Index()
        {
            //TODO: Prompt new Quest or Display details of current
            //Get the current logged in user
            //string id = User.Identity.GetUserId();
            //if (id != null)
            //{
            //    Member member = _context.Members.Where(m => m.ApplicationId == id).FirstOrDefault();
            //    return View(member);
            //}
            return View(await _context.Members.ToListAsync());
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Points,Name")] Member member)
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
            //this.User.ActivePassport = true;
            _context.SaveChanges();
            return View(passport);
        }

        public Passport CreatePassport()
        {
            var potentialStops = _context.Businesses.ToList();
            Passport passport = new Passport();
            ChooseStop(potentialStops, passport.StopOne, true);
            ChooseStop(potentialStops, passport.StopTwo, false);
            ChooseStop(potentialStops, passport.StopThree, false);
            ChooseStop(potentialStops, passport.StopFour, true);
            return passport;
            
        }

        public void ChooseStop(List<Business> list, Stop stop, bool premium)
        {
            int total = list.Count();
            Random r = new Random();
            int offset = r.Next(0, total);
            if (premium == true)
            {
                var newStop = list.Skip(offset).FirstOrDefault();
                while(newStop.Premium == false)
                {
                    newStop = list.Skip(offset).FirstOrDefault();
                }
                list.Remove(newStop);
                stop.BusinessID = newStop.Id;
                //stop.MemberID = this.User.Identity.GetId();
            }
            else
            {
                var newStop = list.Skip(offset).FirstOrDefault();
                list.Remove(newStop);
                stop.BusinessID = newStop.Id;
                //stop.MemberID = this.User.Identity.GetId();
            }
        }

        public bool BusinessCheckIn(Stop stop, int pin)
        {
            if(pin == stop.Business.Pin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Message> GetMesssageList()
        {
            var messageList = _context.Messages.ToList();
            return messageList;
        }

        //Some method that generates the fifth stop if the first four are complete.
        

    }
}
