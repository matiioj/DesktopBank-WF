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
    public class UserRepository : IUserRepository
    {
        private readonly NojedaisticDesktopBankContext _context;

        public UserRepository(NojedaisticDesktopBankContext context)
        {
            _context = context;
        }

        public void CreateUser(User user)
        {
            _context.Users.Add(user);    
        }

        public void DeleteUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public User GetUser(int id)
        {
            var user = _context.Users.Include(a => a.Client).FirstOrDefault(a => a.UserId == id);
            return user;

        }

        public User GetUserByUsername(string username)
        {
            var user = _context.Users.Include(a => a.Client).FirstOrDefault(a => a.UserName == username);
            return user;

        }

        public IEnumerable<User> GetUsers()
        {
            return _context.Users.Include(a => a.Client).ToList();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
