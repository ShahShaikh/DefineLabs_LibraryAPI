using DefineLabs_LibAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineLabs_LibAPI.DAL
{
    interface IBook
    {
        List<Book> GetBookList();

        bool AddBook();

        bool DeleteBook(int id);

        bool UpdateBook(int id);
    }
}
