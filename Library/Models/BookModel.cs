using Library.Enum;
using Library.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        //[Required]
        [MyCustomValidation("Java")]
        public string Tilte { get; set; }
        [Required(ErrorMessage ="You Must Put Author Name")]
        public string Author { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        [Required(ErrorMessage = "Select Language")]
        public int LanguageId { get; set; }
        public string Language { get; set; }
        [Display(Name ="Total Pages")]
        [Required (ErrorMessage ="Pages between 30 - 120")] 
        public int? Pages { get; set; }

    
    }
}
