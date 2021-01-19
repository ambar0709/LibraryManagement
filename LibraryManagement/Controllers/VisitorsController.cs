using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    [Route("api/visitor/{visitorId}")]
    [ApiController]
    public class VisitorsController : ControllerBase
    {
        [Route("books/issuedbyvisitor")]
        public IEnumerable<IssuedBook> GetIssuedBooks(int visitorId)
        {
            return new List<IssuedBook>();
        }

        [Route("book/{bookId}/return")]
        public bool PutReturnBook(int visitorId, int bookId)
        {
            return true;
        }

        [Route("book/{bookId}/issue")]
        public bool PutIssueBook(int visitorId, int bookId)
        {
            return true;
        }
    }
}