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

        public async Task ExecuteTransfer(Account sourceAccount, decimal amount, Account destinationAccount)
        {
            if (sourceAccount == null ||  destinationAccount == null) 
            {
                throw new InvalidOperationException("Ocurrio un error buscando las cuentas");
            }

            if (sourceAccount.AccountBalance < amount)
            {
                throw new InvalidOperationException("No posees suficiente dinero para realizar esta accion");
            }

            sourceAccount.AccountBalance -= amount;
            destinationAccount.AccountBalance += amount;

            var operationCode = _operationCodeRepository.GetOperationCodeByNumberCode(3);
            var transferCode = operationCode.OperationCodeId;
            await _createOperationService.CreateOperationAsync(sourceAccount.AccountId, destinationAccount.AccountId, amount, transferCode); // transfer
            _accountRepository.Update(sourceAccount);
            _accountRepository.Update(destinationAccount);
            await _unitOfWork.SaveChangesAsync();
        }
    }   
}
