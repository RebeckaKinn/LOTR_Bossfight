namespace Bossfight
{
    public class ItemList
    {
        public List<Potion> Items { get; set; }
        public List<BackPackItems> Backpack { get; set; }
        public ItemList()
        {
            Items = new List<Potion>
            {
                new Potion("Health Potion", 1, 100),
                new Potion("Stamina Potion", 2, 2),
                new Potion("Strength Potion", 3, 2),
            };
        }

        public void AddToBackpack(Potion potion, int amount)
        {
            if (Backpack.Any(p => p.Potion == potion))
            {
                var potionToAdd = Backpack.FirstOrDefault(p => p.Potion == potion);
                potionToAdd.AddItems(amount);
            }
            else Backpack.Add(new BackPackItems(potion, amount));
        }

        public void RemoveFromBackPack(BackPackItems potion, int amount)
        {
            if (potion.ShowAmount() == 0)
            {
                Console.WriteLine("You don't have any more of theese!");
            }
            else potion.UseAnItem(amount, Backpack, potion);
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
