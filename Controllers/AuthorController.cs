using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DefineLabs_LibAPI.Models;

namespace DefineLabs_LibAPI.Controllers
{
    public class AuthorController : ApiController
    {

        // GET:api/Author
        public List<Author> GetDetails()
        {

            List<Author> authors = null;
            AuthorDL authorDL = new AuthorDL();
            //Get list of autho
            authors = authorDL.GetAuthorList();

            return authors;
        }

        // GET: api/Author/5
        public Author GetDetails(int id)
        {
            Author autdetail= null;
            AuthorDL authorDL = new AuthorDL();
            //Get list of autho
            autdetail = authorDL.GetListByAuthorID(id);

            return autdetail;
        }

        [HttpPost]
        // POST: api/Author
        public bool Post(string firstName, string lastName)
        {
            AuthorDL authorDL = new AuthorDL();
            bool isAdded = false;
            DateTime dateOfBirth = DateTime.Now;
            isAdded = authorDL.AddAuthor(firstName,lastName, dateOfBirth);
            return isAdded;
        }


        // PUT: api/Author/5
        public bool Put(int id)
        {
            AuthorDL authorDL = new AuthorDL();
            bool IsUpdated = false;
            IsUpdated = authorDL.UpdateAuthor(id);
            return IsUpdated;
        }

        // DELETE: api/Author/5
        public bool Delete(int id)
        {
            AuthorDL authorDL = new AuthorDL();
            bool isDeleted = false;
            isDeleted = authorDL.DeleteAuthor(id);
            return isDeleted;
        }
    }
}
