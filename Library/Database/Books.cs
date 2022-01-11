using System;
namespace Library.Database
{
    public class Books
    {
        public int Id { get; set; }
        public string Tilte { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Language { get; set; }
        public int Pages { get; set; }
    }
}
