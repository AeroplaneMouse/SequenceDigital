using System;
using System.Collections.Generic;

namespace SD.Models
{
    class Player
    {
        private static int _id = 0;

        public int ID { get; }
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

        public Player(string name)
        {
            ID = _id++;
            Name = name;

            // Initiate hand
            Hand = new List<Card>();
        }

        /// <summary>
        /// 
        /// </summary>
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
