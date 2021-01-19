using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        #region Books Action

        [Route("books/list")]
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        [Route("books/{bookId}")]
        public Book GetBook(int bookId)
        {
            return new Book();
        }

        [Route("books/add")]
        public int PostAddBook(Book book)
        {
            return 1;
        }

        [Route("books/{bookId}/update")]
        public bool PutUpdateBook(int bookId, Book book)
        {
            return true;
        }

        [Route("books/{bookId}/delete")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }

        [Route("books/issued")]
        public IEnumerable<IssuedBook> GetAllIssuedBooks()
        {
            return new List<IssuedBook>();
        }

        #endregion

        [Route("visitor/{visitorId}/details")]
        public Visitior GetVisitorDetails(int visitorId)
        {
            return new Visitior();
        }

        [Route("visitor/{visitorId}/books/issued")]
        public IEnumerable<IssuedBook> GetVisitorsIssuedBooks(int visitorId)
        {
            return new List<IssuedBook>();
        }
    }
}