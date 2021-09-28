using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish_dataAccess
{
    public class BookCopies
    {
        public int Id { get; set; }
        public string Borrower { get; set; }
        public DateTime DueDate { get; set; }
        public Book Book { get; set; }

        public bool isAvailable => Borrower == null;
    }
}
