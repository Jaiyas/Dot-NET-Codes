﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DatabaseFirstApprochWithOneTable.Models;

namespace DatabaseFirstApprochWithOneTable.Controllers
{
    public class TblCountries1Controller : Controller
    {
        private readonly CountryJaishriContext _context;

        public TblCountries1Controller(CountryJaishriContext context)
        {
            _context = context;
        }

        // GET: TblCountries1
        public async Task<IActionResult> Index()
        {
            return View(await _context.TblCountries.ToListAsync());
        }

        // GET: TblCountries1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCountry = await _context.TblCountries
                .FirstOrDefaultAsync(m => m.CountryId == id);
            if (tblCountry == null)
            {
                return NotFound();
            }

            return View(tblCountry);
        }

        // GET: TblCountries1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TblCountries1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CountryId,CountryName,CountryCapital,CountryCurrency,CountryContinent")] TblCountry tblCountry)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblCountry);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblCountry);
        }

        // GET: TblCountries1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCountry = await _context.TblCountries.FindAsync(id);
            if (tblCountry == null)
            {
                return NotFound();
            }
            return View(tblCountry);
        }

        // POST: TblCountries1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CountryId,CountryName,CountryCapital,CountryCurrency,CountryContinent")] TblCountry tblCountry)
        {
            if (id != tblCountry.CountryId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblCountry);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TblCountryExists(tblCountry.CountryId))
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
            return View(tblCountry);
        }

        // GET: TblCountries1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblCountry = await _context.TblCountries
                .FirstOrDefaultAsync(m => m.CountryId == id);
            if (tblCountry == null)
            {
                return NotFound();
            }

            return View(tblCountry);
        }

        // POST: TblCountries1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblCountry = await _context.TblCountries.FindAsync(id);
            if (tblCountry != null)
            {
                _context.TblCountries.Remove(tblCountry);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TblCountryExists(int id)
        {
            return _context.TblCountries.Any(e => e.CountryId == id);
        }
    }
}
