using DefineLabs_LibAPI.DAL;
using DefineLabs_LibAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DefineLabs_LibAPI.Controllers
{
    public class BookController : ApiController
    {
        // GET: api/Book
        public List<Book> Get()
        {
            List<Book> books = null;
            BookDL bookDL = new BookDL();
            //Get List of books
            books=bookDL.GetBookList();

            return books;
        }

        // GET: api/Book/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Book
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Book/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Book/5
        public void Delete(int id)
        {
        }
    }
}
