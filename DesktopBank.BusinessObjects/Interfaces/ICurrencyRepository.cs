using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.BusinessObjects.Interfaces
{
    public interface ICurrencyRepository
    {
        IEnumerable<Currency> GetCurrencies();
        Currency GetCurrency(int id);
        void CreateCurrency(Currency currency);
        void UpdateCurrency(Currency currency);
        void DeleteCurrency(int id);
    }
}
