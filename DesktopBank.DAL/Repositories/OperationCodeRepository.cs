using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL.Repositories
{
    public class OperationCodeRepository : BusinessObjects.Interfaces.IOperationCodeRepository
    {
        private readonly NojedaisticDesktopBankContext _context;

        public OperationCodeRepository(NojedaisticDesktopBankContext context)
        {
            _context = context;
        }

        public void CreateOperationCode(OperationCode operationCode)
        {
            _context.OperationCodes.Add(operationCode);
            _context.SaveChanges();
        }

        public void DeleteOperationCode(int id)
        {
            var operationCode = _context.OperationCodes.Find(id);
            _context.OperationCodes.Remove(operationCode);
            _context.SaveChanges();
        }

        public OperationCode GetOperationCode(int id)
        {
            return _context.OperationCodes.Find(id);
        }

        public OperationCode GetOperationCodeByNumberCode(int code)
        {
            return _context.OperationCodes.FirstOrDefault(a => a.OperationCodeNumber == code);
        }

        public IEnumerable<OperationCode> GetOperationCodes()
        {
            return _context.OperationCodes.ToList();
        }

        public void UpdateOperationCode(OperationCode operationCode)
        {
            _context.OperationCodes.Update(operationCode);
            _context.SaveChanges();
        }
    }
}
