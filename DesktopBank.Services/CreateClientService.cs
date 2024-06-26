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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBank.Services
{
    public class CreateClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly UnitOfWork _unitOfWork;



        public CreateClientService(IClientRepository clientRepository, UnitOfWork unitOfWork) 
        {
            _clientRepository = clientRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Client> CreateClientAsync(string name, string surname, long cuil, string mail)
        {
            Client newClient = new Client
            {
                ClientName = name,
                ClientSurname = surname,
                ClientCuil = cuil,
                ClientEmail = mail
            };

            _clientRepository.CreateClient(newClient);
            await _unitOfWork.SaveChangesAsync();
            return newClient;
        }
    }
}
