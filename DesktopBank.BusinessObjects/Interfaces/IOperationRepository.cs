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
        void CreateOperation(Operation operation);
        void UpdateOperation(Operation operation);
        void DeleteOperation(int id);
    }
}
