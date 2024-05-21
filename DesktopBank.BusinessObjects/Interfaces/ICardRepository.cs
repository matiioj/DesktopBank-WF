using DesktopBank.BusinessObjects.Generated.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopBank.BusinessObjects.Interfaces
{
    public interface ICardRepository
    {
        IEnumerable<Card> GetCards();
        Card GetCard(int id);
        IEnumerable<Card> GetCardsByAccount(int accountId);
        Card GetCardByNumber(string cardNumber);
        IEnumerable<Card> GetCardsByStatus(int status);
        void CreateCard(Card card);
        void UpdateCard(Card card);
        void DeleteCard(int id);
    }
}