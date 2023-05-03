namespace Bossfight
{
    public class Item
    {
        public string Name;
        public string Type;
        public int Value;
        public int Id;

        public Item(string name, int id, string type, int value)
        {
            Name = name;
            Type = type;
            Value = value;
            Id = id;
        }

        public virtual void Use(Hero hero, Enemy enemy)
        {
            Console.WriteLine("No use available...");
            Thread.Sleep(1000);
        }

    }
}
