using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookish_dataAccess
{
    class Checkout
    {
        public int CheckoutId { get; set; }
        public int UserId { get; set; }
        public int CopyId { get; set; }
        public DateTime DueDate { get; set; }
    }
}
