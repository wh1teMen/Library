using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        List<Book> books;
        private ApplicationContext _db;
        public BookController(ApplicationContext db)
        {
            _db = db;
        }

        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                _db.Books.Add(book);
                await _db.SaveChangesAsync();
                return RedirectToAction("AddBook");
            }
            return View();
        }
        public IActionResult BookShow()
        {
            var book = _db.Books.ToList();
            return View(book);
        }

    }
}
