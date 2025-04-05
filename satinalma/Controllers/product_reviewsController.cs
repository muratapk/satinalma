using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using satinalma.Data;
using satinalma.Models;

namespace satinalma.Controllers
{
    public class product_reviewsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public product_reviewsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: product_reviews
        public async Task<IActionResult> Index()
        {
              return _context.product_Reviews != null ? 
                          View(await _context.product_Reviews.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.product_Reviews'  is null.");
        }

        // GET: product_reviews/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.product_Reviews == null)
            {
                return NotFound();
            }

            var product_reviews = await _context.product_Reviews
                .FirstOrDefaultAsync(m => m.review_id == id);
            if (product_reviews == null)
            {
                return NotFound();
            }

            return View(product_reviews);
        }

        // GET: product_reviews/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: product_reviews/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("review_id,product_id,customer_id,rating,comment,review_date")] product_reviews product_reviews)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product_reviews);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(product_reviews);
        }

        // GET: product_reviews/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.product_Reviews == null)
            {
                return NotFound();
            }

            var product_reviews = await _context.product_Reviews.FindAsync(id);
            if (product_reviews == null)
            {
                return NotFound();
            }
            return View(product_reviews);
        }

        // POST: product_reviews/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("review_id,product_id,customer_id,rating,comment,review_date")] product_reviews product_reviews)
        {
            if (id != product_reviews.review_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(product_reviews);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!product_reviewsExists(product_reviews.review_id))
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
            return View(product_reviews);
        }

        // GET: product_reviews/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.product_Reviews == null)
            {
                return NotFound();
            }

            var product_reviews = await _context.product_Reviews
                .FirstOrDefaultAsync(m => m.review_id == id);
            if (product_reviews == null)
            {
                return NotFound();
            }

            return View(product_reviews);
        }

        // POST: product_reviews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.product_Reviews == null)
            {
                return Problem("Entity set 'ApplicationDbContext.product_Reviews'  is null.");
            }
            var product_reviews = await _context.product_Reviews.FindAsync(id);
            if (product_reviews != null)
            {
                _context.product_Reviews.Remove(product_reviews);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool product_reviewsExists(int id)
        {
          return (_context.product_Reviews?.Any(e => e.review_id == id)).GetValueOrDefault();
        }
    }
}
