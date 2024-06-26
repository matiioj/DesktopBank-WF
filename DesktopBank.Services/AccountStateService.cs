using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class AccountStateService
    {
        private Account _currentAccount;

        public Account GetCurrentAccount()
        {
            return _currentAccount;
        }

        public void SetCurrentAccount(Account account)
        {
            _currentAccount = account;
        }
    }
}