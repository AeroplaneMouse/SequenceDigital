using System;

namespace SD.Models
{
    class Player
    {
        private static int _id = 0;

        public int ID { get; }
        public string Name { get; set; }

        public Player(string name)
        {
            ID = _id++;
            Name = name;
        }

        public void PlayCard()
        {
            throw new NotImplementedException();
        }

        public void ReturnCards()
        {
            throw new NotImplementedException();
        }
    }
}
