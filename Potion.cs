namespace Bossfight
{
    public class Potion : IItems
    {
        public string Name { get; }
        public int Id { get; }
        public int Value { get; }

        public Potion(string name, int id, int value)
        {
            Name = name;
            Id = id;
            Value = value;
        }
    }
}
