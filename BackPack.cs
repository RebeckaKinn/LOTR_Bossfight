namespace Bossfight
{
    public class BackPack
    {
        public Item Item { get; }
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


    }
}
