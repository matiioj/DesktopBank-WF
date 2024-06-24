using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class CheckAccountTransfer
    {
        private readonly IAccountRepository _accountRepository;
        public CheckAccountTransfer(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Account ExecuteChecker(long cbu)
        {
            var destinationAccount = _accountRepository.GetByCbu(cbu);

            if (destinationAccount == null)
            {
                throw new InvalidOperationException("La cuenta no fue encontrada");
            }

            return destinationAccount;
        }

        public Account ExecuteChecker(string alias)
        {
            var destinationAccount = _accountRepository.GetByAlias(alias);

            if (destinationAccount == null)
            {
                throw new InvalidOperationException("La cuenta no fue encontrada");
            }

            return destinationAccount;
        }
    }
}
