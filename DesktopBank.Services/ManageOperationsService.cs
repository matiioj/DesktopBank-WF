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
            // verifica código de operación
            if (t.OperationCode.OperationCodeNumber == 3) // transferencia
            {
                // si el CBU es el del origen resta el monto
                // si el CBU es el del destino suma el monto
                return t.SourceAccount.AccountCbu == cbu ? -t.OperationAmount : t.OperationAmount;
            }
            else if (t.OperationCode.OperationCodeNumber == 2) // retiro
            {
                // resta el monto
                return -t.OperationAmount;
            }
            else if (t.OperationCode.OperationCodeNumber == 1) // depósito
            {
                // suma el monto
                return t.OperationAmount;
            }
            else if (t.OperationCode.OperationCodeNumber == 4) // otro tipo de operación
            {
                // resta el monto
                return -t.OperationAmount;
            }
            else
            {
                // default: si código de operación no coincide con ninguno de los anteriores
                return t.OperationAmount;
            }
        }

        
    }
}
