using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class AccountInfoService
    {
        private readonly NojedaisticDesktopBankContext _context;
        private readonly AccountRepository _accountRepository;
        private readonly IOperationRepository _operationRepository;
        public AccountInfoService(NojedaisticDesktopBankContext context, AccountRepository accountRepository, OperationRepository operationRepository)  
        {
            _context = context;
            _accountRepository = accountRepository;
            _operationRepository = operationRepository;
        }

        public Account GetAccountByUserId(int userId) 
        {
            Account currentAccount = _accountRepository.GetByUserId(userId);
            return currentAccount;
        }

        public Account GetAccountByAlias(string alias) 
        {
            Account foundAccount = _accountRepository.GetByAlias(alias);
            return foundAccount;
        }

        public Account GetAccountByCbu(long cbu) 
        {
            Account foundAccount = _accountRepository.GetByCbu(cbu);
            return foundAccount;
        }
    }
}
