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
        //dependencias
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

        private readonly Random _random = new Random();
            
        public long GenerateCBU()
        {
            long cbu;
            do
            {
                cbu = GenerateRandomNumber(19);
            } while (_accountRepository.GetByCbu(cbu) != null);
            return cbu;
        }

        public string GenerateAlias()
        {
            string alias;
            alias = GenerateAliasString();
            while (_accountRepository.GetByAlias(alias) != null) 
            {
                alias = GenerateAliasString();  
            }
            return alias;
        }

        private long GenerateRandomNumber(int length)
        {
            const string digits = "0123456789";
            var result = new StringBuilder(length);

            for (int i = 0; i < length; i++)
            {
                result.Append(digits[_random.Next(digits.Length)]);
            }

            return long.Parse(result.ToString());
        }
        private List<string> GenerateListForAlias()
        {
            var list = new List<string> {"CORCHO","FINCA","DORADO","CHARCO","CRUDO", "POZO", "CHANCHO", "PLATA", "PALA", "PICO", "PATO", "CHAPA", "METAL", "MOTO", "CAMPANA" };
            return list;
        }

        private string GenerateAliasString() 
        {
            var list = GenerateListForAlias();
            var random = new Random();
            int index = 0;
            string alias = "";

            for(int i = 0; i < 3; i++) 
            {
                index = random.Next(list.Count);    
                alias += list[index];

                if (i < 2) 
                {
                    alias += ".";
                }
            }

            return alias;
        }
    }
}
