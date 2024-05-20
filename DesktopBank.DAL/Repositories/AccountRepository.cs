using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL.Repositories
{
    public class AccountRepository : IAccountRepository
    {   
        private readonly NojedaisticDesktopBankContext _context;
        public AccountRepository(NojedaisticDesktopBankContext context) 
        {
            _context = context;
        }
        public void Delete(int accountId)
        {
            var account = _context.Accounts.Find(accountId);
            if (account != null)
            {
                _context.Accounts.Remove(account);
                _context.SaveChanges();
            }
        }

        public IEnumerable<Account> GetAll()
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .ToList();
        }

        public Account GetByAlias(string accountAlias)
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .FirstOrDefault(a => a.AccountAlias == accountAlias);
        }

        public Account GetByCbu(long accountCbu)
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .FirstOrDefault(a => a.AccountCbu == accountCbu);
        }

        public IEnumerable<Account> GetByClientId(int clientId)
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .Where(a => a.UserId == clientId)
                .ToList();
        }

        public IEnumerable<Account> GetByCurrencyId(int currencyId)
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .Where(a => a.AccountCurrency == currencyId)
                .ToList();
        }

        public Account GetById(int accountId)
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .FirstOrDefault(a => a.AccountId == accountId);
        }

        public IEnumerable<Account> GetByUserId(int userId)
        {
            return _context.Accounts
                .Include(a => a.User)
                .Include(a => a.AccountCurrencyNavigation)
                .Include(a => a.Cards)
                .Where(a => a.UserId == userId)
                .ToList();
        }

        public void Insert(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        public void Update(Account account)
        {
            _context.Accounts.Update(account);
            _context.SaveChanges();
        }
    }
}
