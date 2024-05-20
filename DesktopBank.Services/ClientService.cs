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
    public class ClientService
    {
        private readonly ClientRepository _clientRepository; 

        public ClientService(ClientRepository clientRepository) 
        {
            _clientRepository = clientRepository;
        }

        public void CreateClient(string name, string surname, int cuil, string mail)
        {
            Client newClient = new Client
            {
                ClientName = name,
                ClientSurname = surname,
                ClientCuil = cuil,
                ClientEmail = mail
            };

            _clientRepository.CreateClient(newClient);
        }
    }
}
