using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GibJohnTutoring.Data;
using GibJohnTutoring.Models;

namespace GibJohnTutoring.Controllers
{
    public class BookTutorsController : Controller
    {
        private readonly GibJohnTutoringContext _context;

        public BookTutorsController(GibJohnTutoringContext context)
        {
            _context = context;
        }

        // GET: BookTutors
        public async Task<IActionResult> Index()
        {
            return View(await _context.BookTutor.ToListAsync());
        }

        // GET: BookTutors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookTutor = await _context.BookTutor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookTutor == null)
            {
                return NotFound();
            }

            return View(bookTutor);
        }


        // GET: BookTutors/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: BookTutors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TutorName,Time,Date")] BookTutor bookTutor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bookTutor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bookTutor);
        }

        // GET: BookTutors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookTutor = await _context.BookTutor.FindAsync(id);
            if (bookTutor == null)
            {
                return NotFound();
            }
            return View(bookTutor);
        }

        // POST: BookTutors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TutorName,Time,Date")] BookTutor bookTutor)
        {
            if (id != bookTutor.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bookTutor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookTutorExists(bookTutor.Id))
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
            return View(bookTutor);
        }

        // GET: BookTutors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bookTutor = await _context.BookTutor
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bookTutor == null)
            {
                return NotFound();
            }

            return View(bookTutor);
        }

        // POST: BookTutors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bookTutor = await _context.BookTutor.FindAsync(id);
            if (bookTutor != null)
            {
                _context.BookTutor.Remove(bookTutor);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookTutorExists(int id)
        {
            return _context.BookTutor.Any(e => e.Id == id);
        }
    }
}
