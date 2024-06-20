namespace CharacterGenerator
{
    public static class Character
    {
        public static Dictionary<Stat, int> Stats { get; private set; }

        static Character()
        {
            Stats = new Dictionary<Stat, int>
            {
                { Stat.Strength, 0 },
                { Stat.Intelligence, 0 },
                { Stat.Dexterity, 0 },
                { Stat.Wisdom, 0 },
                { Stat.Charisma, 0 },
                { Stat.Constitution, 0 }
            };
        }
    }
}