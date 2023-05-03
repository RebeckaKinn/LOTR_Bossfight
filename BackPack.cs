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
        public void AddItems(int addItems)
        {
            Amount += addItems;
        }
        public void UseAnItem(int remove, List<BackPack> Backpack, BackPack item)
        {
            Amount -= remove;
            if (Amount == 0) Backpack.Remove(item);
        }
        public int ShowAmount()
        {
            return Amount;
        }
    }
}
