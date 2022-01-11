using System;
using System.Collections.Generic;
using System.Linq;
using Library.Models;

namespace Library.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {

            return DataSource();
        }

        public BookModel GetBookByID(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> Search(string bookName, string autherName)
        {
            return DataSource().Where(x => x.Tilte.Contains(bookName) || x.Author.Contains(autherName)).ToList();
        }


        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id = 1 , Tilte= "Dart & Flutter",Author = "Mohammed",Description="How To Make Mobile Applications Using Dart & Flutter", Category="Learning", Language="English", Pages=150},
                 new BookModel(){ Id = 2 , Tilte= "Java",Author = "Ahmed",Description="Learn Java Zero To Hero", Category="Studying", Language="Arabic", Pages=89},
                  new BookModel(){ Id = 3 , Tilte= "C#",Author = "Khaled",Description="Introduction to C#", Category="Fun", Language="Roman", Pages=290},
                   new BookModel(){ Id = 4 , Tilte= "C++",Author = "Mohammed",Description="Easy C++ Learning", Category="Food", Language="English", Pages=75},
            };
        }
    }
}
