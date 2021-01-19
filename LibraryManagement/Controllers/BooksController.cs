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
    public class BooksController : ControllerBase
    {
        [Route("list")]
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        [Route("{bookId}")]
        public Book GetBook(int bookId)
        {
            return new Book();
        }

        [Route("add")]
        public int PostAddBook(Book book)
        {
            return 1;
        }

        [Route("{bookId}/update")]
        public bool PutUpdateBook(int bookId, Book book)
        {
            return true;
        }

        [Route("{bookId}/delete")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }
    }
}