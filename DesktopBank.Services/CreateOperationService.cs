using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL.Repositories;
using DesktopBank.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{

    public class CreateOperationService
    {
        private readonly IOperationRepository _operationRepository;
        private readonly UnitOfWork _unitOfWork;
        private readonly GenerateNumbersService _generateNumbersService;

        public CreateOperationService(IOperationRepository operationRepository, UnitOfWork unitOfWork, GenerateNumbersService generateNumbersService)
        {
            _operationRepository = operationRepository;
            _unitOfWork = unitOfWork;
            _generateNumbersService = generateNumbersService;
        }

        public async Task<Operation> CreateOperationAsync(int sourceId, int destinationId, decimal amount, byte operationCodeId)
        {
            Operation newOperation = new Operation
            {
                SourceAccountId = sourceId,
                DestinationAccountId = destinationId,
                OperationNote = "Sin nota",
                OperationAmount = amount,
                OperationCodeId = operationCodeId,


            };

            _operationRepository.CreateOperation(newOperation);
            await _unitOfWork.SaveChangesAsync();
            return newOperation;
        }

        public async Task<Operation> CreateOperationAsync(int sourceId, int destinationId, string note, decimal amount, byte operationCodeId)
        {
            Operation newOperation = new Operation
            {
                SourceAccountId = sourceId,
                DestinationAccountId = destinationId,
                OperationNote = note,
                OperationAmount = amount,
                OperationCodeId = operationCodeId,


            };

            _operationRepository.CreateOperation(newOperation);
            await _unitOfWork.SaveChangesAsync();
            return newOperation;
        }
    }
}

