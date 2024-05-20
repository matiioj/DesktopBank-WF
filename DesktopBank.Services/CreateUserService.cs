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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopBank.Services
{
    public class CreateUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly UnitOfWork _unitOfWork;

        public CreateUserService(IUserRepository userRepository, UnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;   
        }

        public async Task<User> CreateUserAsync(int clientId, string username, string password)
        {
            User newUser = new User
            {
                ClientId = clientId,
                UserName = username,
                UserPassword = password
            };

            _userRepository.CreateUser(newUser);
            await _unitOfWork.SaveChangesAsync();
            return newUser;
        }
    }
}