﻿using System;
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
        private readonly GenerateNumbersService _generateNumbersService;
        public CreateAccountService(IAccountRepository accountRepository, UnitOfWork unitOfWork, GenerateNumbersService generateNumbersService)
        {
            _accountRepository = accountRepository;
            _unitOfWork = unitOfWork;
            _generateNumbersService = generateNumbersService;
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
            long cbu;
            do
            {
                cbu = _generateNumbersService.GenerateRandomNumber(19);
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

        
        private List<string> GenerateListForAlias()
        {
            var list = new List<string> { "CORCHO", "FINCA", "DORADO", "CHARCO", "CRUDO", "POZO", "CHANCHO", "PLATA", "PALA", "PICO", "PATO", "CHAPA", "METAL", "MOTO", "CAMPANA", "TECLA", "TABLA", "KIWI", "FRUTA", "PERA", "BALANZA", "HILO", "CINTO", "COBRE", "IRAN", "TUNICA", "BOLDO", "OVILLO", "INDIGO", "MARCO", "CUENTA", "ARROYO", "FRENO", "REAL", "DELFIN", "MIEL", "BOTE", "ANANA", "DISCO" };
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
