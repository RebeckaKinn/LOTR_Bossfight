namespace Bossfight
{
    public class ItemList
    {
        public List<Item> Items { get; set; }
        public ItemList()
        {
            Items = new List<Item>
            {
                new HealingPotion("Health Potion", "Healing", 100),
                new StaminaPotion("Stamina Potion", "Endurance", 40),
                new StrengthPotion("Strength Potion", "Power", 2),
            };
        }
        public Item DropItem()
        {
            var rnd = new Random();
            int index = rnd.Next(Items.Count);
            Console.WriteLine($"\n***An {Items[index].GetName()} dropped! You put it in your backpack.***");
            return Items[index];
        }
        public Item GetItem(int index)
        {
            return Items[index];
        }
    }
}
