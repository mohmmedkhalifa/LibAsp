using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Models;
using Library.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Library.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository;
        private readonly LanguageRepository _languageRepository;

        //private readonly BookRepository _bookRepository ;

        public BookController(BookRepository bookRepository, LanguageRepository languageRepository)
        {
            _bookRepository = bookRepository;
            _languageRepository = languageRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<ViewResult> GetAllBook()
        {

            var data = await _bookRepository.GetAllBooks();
            return View(data);
        }
        [Route("book-details/{id}")]
        public async Task<ViewResult> GetBook(int id)
        {
            var data = await _bookRepository.GetBookByID(id);
            return View(data);
        }

        public List<BookModel> SearchBook(string bookName, string authorName)
        {
            return _bookRepository.Search(bookName, authorName);
        }

        public async Task<ViewResult> AddBook(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.Langs =new SelectList( await _languageRepository.GetAllLanguage(),"Id", "Name");

            //    var book = new BookModel() { Language = "English"};
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            //  ViewBag.Langs = GetLanguages().Select(x=> new SelectListItem() { Text = x.Text,Value =x.Id.ToString()}).ToList();

            //var g1 = new SelectListGroup() { Name = "Group 1"}; 
            //var g2 = new SelectListGroup() { Name = "Group 2"}; 
            //var g3 = new SelectListGroup() { Name = "Group 3"}; 

          //  ViewBag.Langs = new List<SelectListItem>(){
          //    new() {Value= "1", Text= "Arabic" } ,
          //    new() {Value= "2", Text= "English"} ,
          //    new() {Value= "4", Text= "Deutsh" },
          //    new() {Value= "5", Text= "Urdu"},
          //    new() {Value= "6", Text= "Chinese" },
          //    new() {Value= "7", Text= "Java"}
          //};
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                int id = await _bookRepository.AddNewBook(bookModel);
                if (id > 0)
                {
                    return RedirectToAction(nameof(AddBook), new { isSuccess = true, bookId = id });
                }
            }

            // ModelState.AddModelError(string.Empty, "Error From Controller");
            // ModelState.AddModelError(string.Empty, "New Error From Controller");
            //  ViewBag.Langs = GetLanguages().Select(x => new SelectListItem() { Text = x.Text, Value = x.Id.ToString() }).ToList();
            //var g1 = new SelectListGroup() { Name = "Group 1" };
            //var g2 = new SelectListGroup() { Name = "Group 2" };
            //var g3 = new SelectListGroup() { Name = "Group 3" };


            //  ViewBag.Langs = new List<SelectListItem>(){
            //    new() {Value= "1", Text= "Arabic"} ,
            //    new() {Value= "2", Text= "English" } ,
            //    new() {Value= "4", Text= "Deutsh"},
            //    new() {Value= "5", Text= "Urdu" },
            //    new() {Value= "6", Text= "Chinese" },
            //    new() {Value= "7", Text= "Java"}
            //};
            ViewBag.Langs =new SelectList( await _languageRepository.GetAllLanguage(),"Id", "Name");

            return View();
        }

    }
}
