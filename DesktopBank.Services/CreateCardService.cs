using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using DesktopBank.DAL;
using DesktopBank.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.Services
{
    public class CreateCardService
    {
        private readonly ICardRepository _cardRepository;
        private readonly UnitOfWork _unitOfWork;
        private readonly GenerateNumbersService _generateNumbersService;
        public CreateCardService(ICardRepository cardRepository, UnitOfWork unitOfWork, GenerateNumbersService generateNumbersService) 
        {
            _cardRepository = cardRepository;
            _unitOfWork = unitOfWork;
            _generateNumbersService = generateNumbersService;
        }

        public async Task<Card> CreateCardAsync(int accountId, int accountCurrency)
        {
            Card newCard = new Card
            {
                CardNumber = Convert.ToString(_generateNumbersService.GenerateRandomNumber(16)),
                CardAccountId = accountId,
                CardExpirationDate = DateTime.Parse("2030-05-31 23:59:59"),
                CardCvv = (byte)_generateNumbersService.GenerateRandomNumberForCVV(),
                TypeOfCard = 1, // debit
                StatusOfCard = 1, // active
                CardCurrency = (byte)accountCurrency
            };

            _cardRepository.CreateCard(newCard);
            await _unitOfWork.SaveChangesAsync();
            return newCard;
        }
    }
}
