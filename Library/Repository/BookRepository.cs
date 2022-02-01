using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Library.Database;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Repository
{
    public class BookRepository
    {
        private readonly BookStoreContext _bookStoreContext = null;


        public BookRepository(BookStoreContext context)
        {
            _bookStoreContext = context;
        }

        public async Task<int> AddNewBook(BookModel bookModel)
        {
            var newBook = new Books()
            {

                Author = bookModel.Author,
                CreatedOn = DateTime.UtcNow,
                Description = bookModel.Description,
                LanguageId = bookModel.LanguageId,

                Tilte = bookModel.Tilte,
                Pages = bookModel.Pages.HasValue ? bookModel.Pages.Value : 0,
                UpdatedOn = DateTime.UtcNow

            };

            await _bookStoreContext.Books.AddAsync(newBook);
            await _bookStoreContext.SaveChangesAsync();

            return newBook.Id;
        }
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>();
            var allBooks = await _bookStoreContext.Books.ToListAsync();
            if (allBooks?.Any() == true)
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel()
                    {
                        Author = book.Author,
                        Category = book.Category,
                        Description = book.Description,
                        Id = book.Id,
                        LanguageId = book.LanguageId,
                        Language = book.Language.Name,
                        Tilte = book.Tilte,
                        Pages = book.Pages,
                    });
                }
            }
            return books;
        }

        public async Task<BookModel> GetBookByID(int id)
        {
            return await _bookStoreContext.Books.Where(x => x.Id == id)
                .Select(book => new BookModel()
            {
                Author = book.Author,
                Category = book.Category,
                Description = book.Description,
                Id = book.Id,
                LanguageId = book.LanguageId,
                Language = book.Language.Name,
                Tilte = book.Tilte,
                Pages = book.Pages,
            }).FirstOrDefaultAsync();


        }


        public List<BookModel> Search(string bookName, string autherName)
        {
            //return DataSource().Where(x => x.Tilte.Contains(bookName) || x.Author.Contains(autherName)).ToList();
            return null;
        }


        //private List<BookModel> DataSource()
        //{
        //    return new List<BookModel>()
        //    {
        //        new BookModel(){ Id = 1 , Tilte= "Dart & Flutter",Author = "Mohammed",Description="How To Make Mobile Applications Using Dart & Flutter", Category="Learning", Language="English", Pages=150},
        //         new BookModel(){ Id = 2 , Tilte= "Java",Author = "Ahmed",Description="Learn Java Zero To Hero", Category="Studying", Language="Arabic", Pages=89},
        //          new BookModel(){ Id = 3 , Tilte= "C#",Author = "Khaled",Description="Introduction to C#", Category="Fun", Language="Roman", Pages=290},
        //           new BookModel(){ Id = 4 , Tilte= "C++",Author = "Mohammed",Description="Easy C++ Learning", Category="Food", Language="English", Pages=75},
        //    };
        //}
    }
}
