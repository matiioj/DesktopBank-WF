using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class SessionService
    {
        private readonly IUserRepository? _userRepository;
        private User _currentUser;

        public SessionService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public string CredentialsChecker(string username, string password)
        {
            User user = _userRepository.GetUserByUsername(username);
            string message = string.Empty;
            if (user != null) 
            {
                if (user.UserPassword == password)
                {
                    _currentUser = user;
                    return message;
                }
            }

            message += "Los datos no concuerdan con ningun registro existente.";

            return message;
        }

        public User GetUser() 
        {
            return _currentUser;
        }
    }
}
