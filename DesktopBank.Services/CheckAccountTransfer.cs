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

        public Account ExecuteChecker(string dato)
        {
            var destinationAccount = _accountRepository.GetByAlias(dato);
            

            if (destinationAccount == null)
            {
                destinationAccount = _accountRepository.GetByCbu(long.Parse(dato));
                if (destinationAccount == null) 
                {
                    throw new InvalidOperationException("La cuenta no fue encontrada");
                }
                return destinationAccount;
            }

            return destinationAccount;
        }
    }
}
