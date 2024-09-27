using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebMVC_2.Data;
using WebMVC_2.Models;

namespace WebMVC_2.Controllers
{
    public class AuthsController : Controller
    {
        private readonly DBContext _context;

        public AuthsController(DBContext context)
        {
            _context = context;
        }

        // GET: Auths
        public async Task<IActionResult> Index()
        {
            return View(await _context.Auth.ToListAsync());
        }

        // GET: Auths/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auth = await _context.Auth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (auth == null)
            {
                return NotFound();
            }

            return View(auth);
        }

        // GET: Auths/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Auths/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(/*[Bind("Id,Name")]*/ Auth auth)
        {
            if (ModelState.IsValid)
            {
                _context.Add(auth);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(auth);
        }

        // GET: Auths/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auth = await _context.Auth.FindAsync(id);
            if (auth == null)
            {
                return NotFound();
            }
            return View(auth);
        }

        // POST: Auths/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name")] Auth auth)
        {
            if (id != auth.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(auth);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthExists(auth.Id))
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
            return View(auth);
        }

        // GET: Auths/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var auth = await _context.Auth
                .FirstOrDefaultAsync(m => m.Id == id);
            if (auth == null)
            {
                return NotFound();
            }

            return View(auth);
        }

        // POST: Auths/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var auth = await _context.Auth.FindAsync(id);
            if (auth != null)
            {
                _context.Auth.Remove(auth);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AuthExists(int id)
        {
            return _context.Auth.Any(e => e.Id == id);
        }
    }
}
