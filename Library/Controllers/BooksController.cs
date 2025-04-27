using Library.Models.Contracts.Services;
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
            var books = _bookService.List();
            return View(books);
        }
    }
}
