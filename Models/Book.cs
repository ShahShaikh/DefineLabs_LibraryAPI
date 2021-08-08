using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefineLabs_LibAPI.Models
{
    public class Book
    {
        public int bookID { get; set; }

        public string bookTitle { get; set; }

        public int authorID { get; set; }

        //public List<Author> authors { get; set; }
    }
}