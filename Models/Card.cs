namespace SD.Models
{
    enum Suit { Diamonds, Clubs, Hearts, Spades}
    enum Cvalue { One, Two, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace}

    class Card
    {
        public Suit Suit { get; private set; }
        public Cvalue Value { get; private set; }
        public int ColorGroup { get; private set; }

        public Card(Suit suit, Cvalue value)
        {
            Suit = suit;
            Value = value;

            // Set color group. 0 for red, 1 for black.
            ColorGroup = (suit == Suit.Diamonds || suit == Suit.Hearts) ? 0 : 1;
        }
    }
}
