using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly NojedaisticDesktopBankContext _context;
        public ClientRepository(NojedaisticDesktopBankContext context) 
        {
            _context = context;
        }
        public void CreateClient(Client client)
        {
            _context.Clients.Add(client);
            _context.SaveChanges();
        }

        public void DeleteClient(int id)
        {
            var client = _context.Clients.Find(id);
            if (client != null)
            {
                _context.Clients.Remove(client);
                _context.SaveChanges();
            }
        }

        public Client GetClient(int id)
        {
            var client = _context.Clients.Include(a => a.Users).FirstOrDefault(a => a.ClientId == id);
            return client;
        }

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients.Include(a => a.Users).ToList();
        }

        public void UpdateClient(Client client)
        {
            _context.Clients.Update(client);
            _context.SaveChanges();
        }
    }
}