using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.BusinessObjects.Interfaces
{
    public interface IOperationCodeRepository
    {
        IEnumerable<OperationCode> GetOperationCodes();
        OperationCode GetOperationCode(int id);

        OperationCode GetOperationCodeByNumberCode(int code);
        void CreateOperationCode(OperationCode operationCode);
        void UpdateOperationCode(OperationCode operationCode);
        void DeleteOperationCode(int id);
    }
}
