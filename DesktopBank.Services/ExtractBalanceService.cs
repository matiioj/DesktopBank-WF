using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class ExtractBalanceService
    {
        private readonly AccountRepository _accountRepository;
        private readonly CreateOperationService _createOperationService;
        private readonly UnitOfWork _unitOfWork;
        public ExtractBalanceService(AccountRepository accountRepository, CreateOperationService createOperationService, UnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _createOperationService = createOperationService;
            _unitOfWork = unitOfWork;
        }

        public async Task ExtractBalanceFromAccount(Account currentAccount, decimal amount) 
        {
            var accountToUpdate = currentAccount;
            if (currentAccount == null)
            {
                return;
            }

            accountToUpdate.AccountBalance -= amount;
            await _createOperationService.CreateOperationAsync(currentAccount.AccountId, currentAccount.AccountId, amount, 2); // 1: extract
            _accountRepository.Update(accountToUpdate);
            await _unitOfWork.SaveChangesAsync();

        }
        
    }
}

