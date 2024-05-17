using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Entities
{
    public class Account
    {
        public uint Id { get; set; }

        public byte AccountType { get; set; } //revisar

        public uint Balance { get; set; }

        public uint ForeignCurrency { get; set; }

        public uint Cbu { get; set; }

        public string Alias { get; set; }

        public string UserName {  get; set; }

        public string Password { get; set; }

    }
}
