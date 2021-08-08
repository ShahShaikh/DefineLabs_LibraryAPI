using DefineLabs_LibAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineLabs_LibAPI.DAL
{
   public interface IAuthor
    {
         List<Author> GetAuthorList();
         Author GetListByAuthorID(int id);
         bool AddAuthor(string firstName,string lastName,DateTime dateOfBirth);
         bool DeleteAuthor(int id);
         bool UpdateAuthor(int id);





    }
}
