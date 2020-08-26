using System;
using System.Collections.Generic;
using System.Text;

namespace SD.Models
{
    class Deck
    {
        public List<Card> Cards { get; }

        public Deck()
        {
            // Initialize card deck
            Cards = new List<Card>();
        }

        /// <summary>
        /// Shuffles the deck
        /// </summary>
        public void Shuffle()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the top card in the deck
        /// </summary>
        public Card DrawCard()
        {
            throw new NotImplementedException();
        }

    }
}
