namespace Bossfight
{
    public class BackPack
    {
        public Item Item;
        public int Amount { get; set; }
        public BackPack(Item newItem, int amount)
        {
            Item = newItem;
            Amount = amount;
        }
        public void AddItems(int addItems = 1)
        {
            Amount += addItems;
        }

        public void ShowItems(int index)
        {
            Console.WriteLine($"{index} - {Item.GetName()} ({Amount})");
        }
    }
}
