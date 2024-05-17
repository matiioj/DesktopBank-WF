using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Entities
{
    internal class Transfer
    {
        public int TransactionNumber { get; set; }

        public int AccountOrigin {  get; set; }

        public int AccountDestination { get; set; }

        public int Amount { get; set; }

        public int Currency { get; set; }
    }
}
