﻿namespace Bossfight
{
    public class ItemList
    {
        public List<Item> Items { get; set; }
        public ItemList()
        {
            Items = new List<Item>
            {
                new HealingPotion("Health Potion", 1, "Healing", 100),
                new StaminaPotion("Stamina Potion", 2, "Endurance", 2),
                new StrengthPotion("Strength Potion", 3, "Power", 2),
            };
        }

        public Item DropItem(Random rnd)
        {
            int index = rnd.Next(Items.Count);
            Console.WriteLine("A potion dropped! You put it in your backpack.");
            return Items[index];
        }

        public Item GetItem(int index)
        {
            return Items[index];
        }
    }
}
