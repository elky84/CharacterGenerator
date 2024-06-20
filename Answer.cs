namespace CharacterGenerator
{
    public class Answer(string text, Dictionary<Stat, int> stats)
    {
        public string Text { get; private set; } = text;

        public Dictionary<Stat, int> Stats { get; private set; } = stats;
    }
}