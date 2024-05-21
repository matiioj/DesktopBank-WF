using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly NojedaisticDesktopBankContext _context;
        public CurrencyRepository(NojedaisticDesktopBankContext context)
        {
            _context = context;
        }

        public IEnumerable<Currency> GetCurrencies()
        {
            return _context.Currencies.ToList();
        }

        public Currency GetCurrency(int id)
        {
            return _context.Currencies.Find(id);
        }

        public void CreateCurrency(Currency currency)
        {
            _context.Currencies.Add(currency);
            _context.SaveChanges();
        }

        public void UpdateCurrency(Currency currency)
        {
            var existingCurrency = _context.Currencies.Find(currency.CurrencyId);
            if (existingCurrency != null)
            {
                existingCurrency.CurrencyName = currency.CurrencyName;
                existingCurrency.CurrencySign = currency.CurrencySign;
                _context.SaveChanges();
            }
        }

        public void DeleteCurrency(int id)
        {
            var currency = _context.Currencies.Find(id);
            if (currency != null)
            {
                _context.Currencies.Remove(currency);
                _context.SaveChanges();
            }
        }

    }
}
