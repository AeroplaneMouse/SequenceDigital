namespace SD.Models
{
    class Team
    {
        private static int _id = 0;

        public int ID { get; }
        public string Name { get; set; }

        public Team(string name)
        {
            ID = _id++;
            Name = name;
        }
    }
}
