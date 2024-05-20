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
        Account GetByCbu(long accountCbu);
        IEnumerable<Account> GetByUserId(int userId);
        IEnumerable<Account> GetByClientId(int clientId);
        IEnumerable<Account> GetByCurrencyId(int currencyId);
        void Insert(Account account);
        void Update(Account account);
        void Delete(int accountId);

    }
}