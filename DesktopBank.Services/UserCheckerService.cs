using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL.Repositories;
using DesktopBank.Services;
using System.Security.Cryptography;
using System.Text;

public class UserCheckerService
{
    private readonly IUserRepository _userRepository;
    private readonly PasswordHashingService _passwordHashingService;

    public UserCheckerService(IUserRepository userRepository, PasswordHashingService passwordHashingService) 
    {
        _userRepository = userRepository;
        _passwordHashingService = passwordHashingService;
    }

    public string CredentialsChecker(string username, string password)
    {
        User user = _userRepository.GetUserByUsername(username);
        string message = string.Empty;
        if (user != null)
        {
            var hashedPassword = _passwordHashingService.HashPassword(password);
            if (user.UserPassword == hashedPassword)
            {
                message += user.UserId;
                return message;
            }
        }

        message += "Los datos no concuerdan con ningún registro existente.";
        return message;
    }
}