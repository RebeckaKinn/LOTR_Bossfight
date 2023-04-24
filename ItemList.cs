namespace Bossfight
{
    public class ItemList
    {
        public List<string> Items { get; set; }
        public ItemList()
        {
            Items = new List<string>
            {
                new string("Health Potion"),
                new string("Stamina Potion"),
                new string("Strength Potion"),
            };
        }
        public string GetItem(int index)
        {
            return Items[index];
        }

        public void UseItem(string chosenItem, Character character)
        {
            if (GetItem(0) == chosenItem) character.UseHealthPotion();
            if (GetItem(1) == chosenItem) character.UseStaminaPotion();
            if (GetItem(2) == chosenItem) character.UseStrengthPotion();
        }

        public void ScrollThroughItems()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine($"{number} - {Items[i]}");
            };
            Console.ReadLine();
        }
    }
}
