using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class ManageOperationsService
    {
        private readonly IOperationRepository _operationRepository;
        private readonly UnitOfWork _unitOfWork;
        

        public ManageOperationsService(IOperationRepository operationRepository, UnitOfWork unitOfWork)
        {
            _operationRepository = operationRepository;
            _unitOfWork = unitOfWork;
        }

        public decimal GetSignedAmount(Operation t, long cbu)
        {
            if (t.OperationCode.OperationCodeNumber == 3)
            {
                return t.SourceAccount.AccountCbu == cbu ? -t.OperationAmount : t.OperationAmount;
            }
            else if (t.OperationCode.OperationCodeNumber == 2)
            {
                return -t.OperationAmount;
            }
            else if (t.OperationCode.OperationCodeNumber == 1)
            {
                return t.OperationAmount; 
            }
            else if (t.OperationCode.OperationCodeNumber == 4) { 
                return -t.OperationAmount;
            }
            else
            {
                return t.OperationAmount; 
            }
        }
    }
}
