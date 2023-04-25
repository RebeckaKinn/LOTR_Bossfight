namespace Bossfight
{
    public class ItemList
    {
        public List<Potion> Items { get; set; }
        public int Id { get; }
        public ItemList()
        {
            Items = new List<Potion>
            {
                new Potion("Health Potion", 1),
                new Potion("Stamina Potion", 2),
                new Potion("Strength Potion", 3),
            };
        }

        public bool ConfirmID(int input)
        {
            return Items.Any(p => p.Id == input);
        }

        public bool IsItemInInventory(int index)
        {
            for (int i = 1; i < Items.Count; i++)
            {
                if (i == index) return true;
                break;
            }
            return false;
        }
        public void ScrollThroughItems()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine($"{number} - {Items[i].Name}");
            };
        }
    }
}
