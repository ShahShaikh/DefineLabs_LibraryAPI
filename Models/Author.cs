using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DefineLabs_LibAPI.Models
{
    public class Author
    {
        public int authorId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime dateOfBirth { get; set; }

        public List<Book> books { get; set; }
    }
}