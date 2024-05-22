using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopBank.BusinessObjects.Generated.Models;
using DesktopBank.BusinessObjects.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DesktopBank.DAL.Repositories
{
    public class CardRepository : ICardRepository
    {
        NojedaisticDesktopBankContext _context;
        public CardRepository(NojedaisticDesktopBankContext context) 
        {
            _context = context;
        } 
        public void CreateCard(Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
        }

        public void DeleteCard(int id)
        {
            var card = _context.Cards.Find(id);
            if (card != null)
            {
                _context.Cards.Remove(card);
                _context.SaveChanges();
            }
        }

        public Card GetCard(int id)
        {
            var card = _context.Cards.Find(id);
            return card;
        }

        public IEnumerable<Card> GetCardsByAccount(int accountId)
        {
            var cards = _context.Cards.Where(a => a.CardAccountId == accountId).ToList();
            return cards;
        }

        public Card GetCardByNumber(string cardNumber)
        {
            var card = _context.Cards.Where(a => a.CardNumber == cardNumber).FirstOrDefault();
            return card;
        }

        public IEnumerable<Card> GetCardsByStatus(int status)
        {
            var cards = _context.Cards.Where(a => a.StatusOfCard == status).ToList();
            return cards;
        }

        public IEnumerable<Card> GetCards()
        {
            return _context.Cards
                .Include(a => a.CardAccount)
                .ToList();
        }

        public void UpdateCard(Card card)
        {
            _context.Update(card);
            _context.SaveChanges();
        }


    }
}
