using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Entities
{
    public class DebitCard
    {
        public ulong DebitNumber { get; set; }

        public int AssociatedAccountNumber { get; set; }

        public string ExpirationDate { get; set; } //revisar conversion a tipo date para la base

        public int CardVerificationValue { get; set; }
    }
}
