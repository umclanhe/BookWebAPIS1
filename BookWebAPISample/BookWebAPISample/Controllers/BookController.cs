using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BookWebAPISample.Models;

namespace BookWebAPISample.Controllers
{
    public class BookController : ApiController
    {
        Book[] books = new Book[]
        {
            new Book {Id = 1, ISBN = "068484267X", Title = "Angela's Ashes: AMemoir", AuthorName = "Frank McCourt"},
            new Book {Id = 2, ISBN = "014242417X", Title = "The Fault in Our Stars", AuthorName = "John Green"},
            new Book {Id = 3, ISBN = "1594633665", Title = "The Girl on the Train", AuthorName = "Paula Hawkins"}
        };

        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }

       public IHttpActionResult GetBook(int id)
        {
            var book = books.FirstOrDefault((bk) => bk.Id == id);
            if(book == null)
            {
                return NotFound();
            }
            return Ok(book);             
        }  
    }
}
