using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL.Repositories
{
    internal class OperationCodeRepository : IOperationCodeRepository
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
            var operationCode = _context.OperationCodes.Find(id) ;
            _context.OperationCodes.Remove(operationCode);
            _context.SaveChanges();
        }

        public OperationCode GetOperationCode(int id)
        {
            return _context.OperationCodes.Find(id);
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
