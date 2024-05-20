using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DesktopBank.DAL.UnitOfWork;

namespace DesktopBank.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly NojedaisticDesktopBankContext _context;

        public UnitOfWork(NojedaisticDesktopBankContext context)
            {
                _context = context;
            }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
        
        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _context.Database.BeginTransactionAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
