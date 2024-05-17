using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string Name {  get; set; }

        public string Surname { get; set; }

        public string Cuil {  get; set; }

        public string Mail { get; set; }
    }
}
