﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Infrastructure.Data;
using System.Security.Claims;
using BeerQuest.Helper;

namespace BeerQuest.Controllers
{
    public class BusinessesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BusinessesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Businesses
        public async Task<IActionResult> Index()
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var loggedInBusiness = _context.Businesses.Single(b => b.ApplicationId == currentUserId);
            return View(loggedInBusiness);
            //return View(await _context.Businesses.ToListAsync());
        }

        // GET: Businesses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Businesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // GET: Businesses/Create
        public IActionResult Create()
        {
            Business business = new Business();
            return View(business);
        }

        // POST: Businesses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address,City,State,Pin")] Business business)
        {
            var currentUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);
            var latlng = GoogleGeoCoding.GetLatLong(business);
            if (ModelState.IsValid)
            {
                business.ApplicationId = currentUserId;
                business.lat = latlng[0];
                business.lng = latlng[1];
                _context.Add(business);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(business);
        }

        // GET: Businesses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Businesses.FindAsync(id);
            if (business == null)
            {
                return NotFound();
            }
            return View(business);
        }

        // POST: Businesses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address,City,State,Pin")] Business business)
        {
            if (id != business.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(business);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessExists(business.Id))
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
            return View(business);
        }

        // GET: Businesses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var business = await _context.Businesses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (business == null)
            {
                return NotFound();
            }

            return View(business);
        }

        // POST: Businesses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var business = await _context.Businesses.FindAsync(id);
            _context.Businesses.Remove(business);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessExists(int id)
        {
            return _context.Businesses.Any(e => e.Id == id);
        }
        public void GetPremium(Business business)
        {
            business.Premium = true;
            _context.SaveChanges();
        }
        
        public void GetMembersVisited(Business business)
        {
            var membersList = _context.Members.ToList();
            var relevantMembersList = new List<Member>();
            
            foreach (Member el in membersList)
            {
                //if ( el.passport.completedVisitAt == business.location ){
                //relevantMembersList.Add(el);
                //}
            }
        }
    }
}
