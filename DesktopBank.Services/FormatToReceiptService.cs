using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class FormatToReceiptService
    {
        private readonly NojedaisticDesktopBankContext _context;
        private readonly OperationRepository _operationRepository;

        public FormatToReceiptService(OperationRepository operationRepository) 
        {
            _context = new();
            _operationRepository = new(_context);
        }

        public Dictionary<string, string> GenerateTransferReceiptData(int id)
        {
            Dictionary<string, string> transferData = new();
            var operation = _operationRepository.GetOperation(id);
            var operationDate = operation.OperationDate.ToString("dd-MM-yyyy HH:mm", CultureInfo.InvariantCulture);
            var operationNumber = $"{operation.OperationId}";
            var operationNote = operation.OperationNote;
            var operationAmount = $"{operation.OperationAmount}";

            var senderName = $"{operation.SourceAccount.User.Client.ClientName} {operation.SourceAccount.User.Client.ClientSurname}";
            var senderCUIL = FormatCuil($"{operation.SourceAccount.User.Client.ClientCuil}");
            var senderCBU = $"{operation.SourceAccount.AccountCbu}";

            var receiverName = $"{operation.DestinationAccount.User.Client.ClientName} {operation.DestinationAccount.User.Client.ClientSurname}";
            var receiverCUIL = FormatCuil($"{operation.DestinationAccount.User.Client.ClientCuil}");
            var receiverCBU = $"{operation.DestinationAccount.AccountCbu}";

            transferData.Add("OperationDate", operationDate);
            transferData.Add("OperationNumber", operationNumber);
            transferData.Add("OperationNote", operationNote);
            transferData.Add("OperationAmount", operationAmount);
            transferData.Add("SenderName", senderName);
            transferData.Add("SenderCUIL", senderCUIL);
            transferData.Add("SenderCBU", senderCBU);
            transferData.Add("ReceiverName", receiverName);
            transferData.Add("ReceiverCUIL", receiverCUIL);
            transferData.Add("ReceiverCBU", receiverCBU);

            return transferData;
        }

        internal string FormatCuil(string cuil)
        {
            if (cuil.Length == 11)
            {
                return $"{cuil.Substring(0, 2)}-{cuil.Substring(2, 8)}-{cuil.Substring(10, 1)}";
            }
            return cuil;
        }
    }
}
