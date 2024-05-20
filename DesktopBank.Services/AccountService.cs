using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBank.Services
{
    public class AccountService
    {
        private readonly AccountRepository _accountRepository;
        public AccountService(AccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public void CrearCuenta(string nombre, string apellido, string correo, string cuil) 
        {

        }
    }
}
