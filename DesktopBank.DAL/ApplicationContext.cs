using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL
{
    public static class ApplicationContext
    {
        private static Account _currentAccount;

        public static Account CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; }
        }
    }
}
