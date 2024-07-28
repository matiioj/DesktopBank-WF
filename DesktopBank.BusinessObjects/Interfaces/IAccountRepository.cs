using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    

namespace DesktopBank.BusinessObjects.Interfaces
{
    public interface IAccountRepository
    {

        IEnumerable<Account> GetAll();
        Account GetById(int accountId);
        Account GetByAlias(string accountAlias);

        Account GetByEmail(string email);   
        Account GetByCbu(long accountCbu);
        Account GetByUserId(int userId);
        IEnumerable<Account> GetAccountsByUserId(int userId);
        IEnumerable<Account> GetByCurrencyId(int currencyId);
        void Insert(Account account);
        void Update(Account account);
        void Delete(int accountId);

    }
}