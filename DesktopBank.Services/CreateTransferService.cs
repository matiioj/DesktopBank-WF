using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.DAL.Repositories;
using DesktopBank.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopBank.BusinessObjects.Interfaces;

namespace DesktopBank.Services
{
    public class CreateTransferService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly CreateOperationService _createOperationService;
        private readonly UnitOfWork _unitOfWork;
        private readonly IOperationCodeRepository _operationCodeRepository;
        public CreateTransferService(IOperationCodeRepository operationCodeRepository, IAccountRepository accountRepository, CreateOperationService createOperationService, UnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _createOperationService = createOperationService;
            _operationCodeRepository = operationCodeRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task ExecuteTransfer(Account currentAccount, decimal amount, long cbu)
        {
            var sourceAccount = currentAccount;
            var destinationAccount = _accountRepository.GetByCbu(cbu);

            if (sourceAccount == null || destinationAccount == null)
            {
                throw new InvalidOperationException("La cuenta no fue encontrada");
            }

            if (sourceAccount.AccountBalance < amount) 
            {
                throw new InvalidOperationException("No posees suficente dinero para realizar esta accion");
            }

            sourceAccount.AccountBalance -= amount;
            destinationAccount.AccountBalance += amount;


            await _createOperationService.CreateOperationAsync(sourceAccount.AccountId, destinationAccount.AccountId, amount, 3); // transfer
            _accountRepository.Update(sourceAccount);
            _accountRepository.Update(destinationAccount);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task ExecuteTransfer(Account currentAccount, decimal amount, string alias)
        {
            var sourceAccount = currentAccount;
            var destinationAccount = _accountRepository.GetByAlias(alias);

            if (sourceAccount == null || destinationAccount == null)
            {
                throw new InvalidOperationException("La cuenta no fue encontrada");
            }

            if (sourceAccount.AccountBalance < amount)
            {
                throw new InvalidOperationException("No posees suficente dinero para realizar esta accion");
            }

            sourceAccount.AccountBalance -= amount;
            destinationAccount.AccountBalance += amount;


            await _createOperationService.CreateOperationAsync(sourceAccount.AccountId, destinationAccount.AccountId, amount, 3); // transfer
            _accountRepository.Update(sourceAccount);
            _accountRepository.Update(destinationAccount);
            await _unitOfWork.SaveChangesAsync();
        }
}
}
