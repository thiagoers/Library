using Library.Models.Contracts.Services;
using Library.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;
        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            try
            {
                var books = _bookService.List();
                return View(books);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Name", "Author", "Publisher")] BookDTO book)
        {
            try
            {
                _bookService.Add(book);
                return RedirectToAction("List");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IActionResult Edit(string? id)
        {
            try
            {
                if (string.IsNullOrEmpty(id))
                    return NotFound();

                var book = _bookService.SearchById(id);

                if (book == null)
                    return NotFound();

                return View(book);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit([Bind("Id","Name", "Author", "Publisher")] BookDTO book)
        {
            try
            {
                _bookService.UpdateBook(book);
                return RedirectToAction("List");

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
