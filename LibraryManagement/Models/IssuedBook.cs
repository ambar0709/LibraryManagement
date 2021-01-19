using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.Models
{
    public class IssuedBook
    {
        public int BookId { get; set; }

        public string BookTitle { get; set; }

        public int VisitorId { get; set; }

        public string VisitorName { get; set; }

        public DateTime IssuedOn { get; set; }

        public int IssuedBy { get; set; }

        public DateTime ReturningDate { get; set; }

        public bool IsReturned { get; set; }

        public bool ReturnedOn { get; set; }
    }
}
