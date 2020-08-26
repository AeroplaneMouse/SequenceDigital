using System;
using System.Collections.Generic;

namespace SD.Models
{
    enum Location { TOP, BOTTOM }

    class Deck
    {
        public List<Card> Cards { get; }

        public Deck()
            : this(new List<Card>()) { }

        public Deck(List<Card> initialCards)
        {
            // Initialize card deck
            Cards = initialCards;
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

        /// <summary>
        /// Adds a card to the top or bottom of the deck
        /// </summary>
        /// <param name="c">The card to be placed in the deck</param>
        /// <param name="location">The location where the card is placed in the deck</param>
        public void AddCard(Card c, Location location = Location.TOP)
        {
            throw new NotImplementedException();
        }
    }
}
