using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public ViewResult GetAllBook()
        {
            var data = _bookRepository.GetAllBooks();
            return View(data);
        }
        [Route("book-details/{id}")]
        public ViewResult GetBook(int id)
        {
            var data = _bookRepository.GetBookByID(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName,string authorName)
        {
            return _bookRepository.Search(bookName,authorName);
        }

        public ViewResult AddBook()
        {
            
            return View();
        }

        [HttpPost]
        public ViewResult AddBook(BookModel bookModel)
        {

            return View();
        }
    }
}
