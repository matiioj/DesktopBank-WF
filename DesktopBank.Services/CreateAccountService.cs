using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBank.Services
{
    public class CreateAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly UnitOfWork _unitOfWork;
        public CreateAccountService(IAccountRepository accountRepository, UnitOfWork unitOfWork)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<Account> CreateAccountAsync(int userId, int currencyId) 
        {
            Account account = new Account
            {
                UserId = userId,
                AccountAlias = GenerateAlias(),
                AccountCbu = GenerateCBU(),
                AccountCurrency = currencyId
            };

            _accountRepository.Insert(account);
            await _unitOfWork.SaveChangesAsync();
            return account;

        }

        public long GenerateCBU() 
        {
            return 12345678901; // to do
        }

        public string GenerateAlias()
        {
            return "PALO.PICO.PALA"; // to do
        }
    }
}
