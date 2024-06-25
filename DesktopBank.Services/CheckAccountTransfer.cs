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


            if (destinationAccount == null) {
                try
                {
                    long parsedDato = long.Parse(dato);
                    destinationAccount = _accountRepository.GetByCbu(parsedDato);

                    if (destinationAccount == null)
                    {
                        throw new InvalidOperationException("La cuenta no fue encontrada");
                    }

                    return destinationAccount;
                }
                catch (FormatException)
                {
                    throw new InvalidOperationException("La cuenta no fue encontrada");
                }
            }

            return destinationAccount;
        }
    }
}
