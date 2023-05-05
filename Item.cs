namespace Bossfight
{
    public class Item
    {
        private string _name;
        public string Type;
        private int _value;

        public Item(string name, string type, int value)
        {
            _name = name;
            Type = type;
            _value = value;
        }
        public virtual void Use(Hero hero, Enemy enemy)
        {
            Console.WriteLine("No use available...");
            Thread.Sleep(1000);
        }

        public string GetName()
        {
            return _name;
        }
        public int GetValue()
        {
            return _value;
        }
    }
}
