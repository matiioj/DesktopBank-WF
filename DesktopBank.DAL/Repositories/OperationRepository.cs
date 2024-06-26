﻿using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.DAL.Repositories
{
    public class OperationRepository : IOperationRepository
    {

        private readonly NojedaisticDesktopBankContext _context;
        public OperationRepository(NojedaisticDesktopBankContext context)
        {
            _context = context; 
        }

        public void CreateOperation(Operation Operation)
        {
            _context.Operations.Add(Operation);
            _context.SaveChanges();
        }

        public void DeleteOperation(int id)
        {
            var Operation = _context.Operations.Find(id);
            _context.Operations.Remove(Operation);
            _context.SaveChanges();
        }

        public Operation GetOperation(int id)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .FirstOrDefault(a => a.OperationId == id);
        }

        public Operation GetLastOperationBySenderCBU(long cbu)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .Where(a => a.SourceAccount.AccountCbu == cbu)
                .OrderByDescending(a => a.OperationDate) // Replace 'Date' with your actual timestamp field
                .FirstOrDefault();
        }

        public Operation GetLastOperationByReceiverCBU(long cbu)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .Where(a => a.DestinationAccount.AccountCbu == cbu)
                .OrderByDescending(a => a.OperationDate) 
                .FirstOrDefault();
        }

        public IEnumerable<Operation> GetOperations()
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .ToList();
        }

        public IEnumerable<Operation> GetOperationsByCurrency(int currencyId)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client).
                Where(a => a.SourceAccount.AccountCurrency == currencyId).ToList();
        }

        public IEnumerable<Operation> GetOperationsByOperationCode(int operationCode)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .Where(a => a.OperationCodeId == operationCode).ToList();
        }

        public IEnumerable<Operation> GetOperationsByReceiverCBU(long cbu)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .Where(a => a.DestinationAccount.AccountCbu == cbu).ToList();
        }

        public IEnumerable<Operation> GetOperationsBySenderCBU(long cbu)
        {
            return _context.Operations
                .Include(a => a.OperationCode)
                .Include(a => a.OperationCode)
                .Include(a => a.SourceAccount)
                .Include(a => a.SourceAccount.User)
                .Include(a => a.SourceAccount.User.Client)
                .Include(a => a.DestinationAccount)
                .Include(a => a.DestinationAccount.User)
                .Include(a => a.DestinationAccount.User.Client)
                .Where(a => a.SourceAccount.AccountCbu == cbu).ToList();
            
        }

        public void UpdateOperation(Operation Operation)
        {
            _context.Operations.Update(Operation);
            _context.SaveChanges();
        }
    }
}
