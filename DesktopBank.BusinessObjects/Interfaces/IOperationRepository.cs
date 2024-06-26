using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.BusinessObjects.Interfaces
{
    public interface IOperationRepository
    {
        IEnumerable<Operation> GetOperations();
        Operation GetOperation(int id);
        public Operation GetLastOperationBySenderCBU(long cbu);
        public Operation GetLastOperationByReceiverCBU(long cbu);
        IEnumerable<Operation> GetOperationsBySenderCBU(long cbu);
        IEnumerable<Operation> GetOperationsByReceiverCBU(long cbu);
        IEnumerable<Operation> GetOperationsByCurrency(int currencyId);
        IEnumerable<Operation> GetOperationsByOperationCode(int operationCode);
        void CreateOperation(Operation operation);
        void UpdateOperation(Operation operation);
        void DeleteOperation(int id);
    }
}
