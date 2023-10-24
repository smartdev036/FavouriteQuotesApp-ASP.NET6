using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FavouriteQuotesApp.Models;
using System.Linq;
using System.Threading.Tasks;
using FavouriteQuotesApp.Entities;

namespace FavouriteQuotesApp.Controllers
{
    public class QuoteController : Controller
    {
        private readonly QuotesDbContext _context;

        public QuoteController(QuotesDbContext context)
        {
            _context = context;
        }

        // GET: Quote
        public async Task<IActionResult> Index()
        {
            var quotes = await _context.Quotes.OrderByDescending(q => q.Rating).ToListAsync();
            return View(quotes);
        }

        // GET: Quote/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quotes.FirstOrDefaultAsync(q => q.Id == id);

            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        // GET: Quote/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Text,Author,Rating,Description")] Quote quote)
        {
            if (ModelState.IsValid)
            {
                _context.Add(quote);
                await _context.SaveChangesAsync();
                TempData["Message"] = "Quote added successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View(quote);
        }

        // GET: Quote/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var quote = await _context.Quotes.FindAsync(id);

            if (quote == null)
            {
                return NotFound();
            }

            return View(quote);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Text,Author,Rating,Description")] Quote quote)
        {
            if (id != quote.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(quote);
                    await _context.SaveChangesAsync();
                    TempData["Message"] = $"Quote \"{quote.Text}\" updated successfully.";
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuoteExists(quote.Id))
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
            return View(quote);
        }

        private bool QuoteExists(int id)
        {
            return _context.Quotes.Any(q => q.Id == id);
        }
    }
}
