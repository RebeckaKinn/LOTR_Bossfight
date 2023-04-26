namespace Bossfight
{
    public class BackPackItems
    {
        public Potion Potion { get; }
        public int Amount { get; set; }
        public BackPackItems(Potion newPotion, int amount)
        {
            Potion = newPotion;
            Amount = amount;
        }
        public void AddItems(int addItems)
        {
            Amount += addItems;
        }
        public void UseAnItem(int remove, List<BackPackItems> Backpack, BackPackItems item)
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
