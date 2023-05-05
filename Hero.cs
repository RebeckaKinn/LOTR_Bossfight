namespace Bossfight
{
    public class Hero : GameCharacter
    {
        public List<BackPack>? Backpack { get; set; }

        public Hero(string name, int health, int strength, int stamina) : base(name, health, strength, stamina)
        {
            Backpack = new List<BackPack>();
        }

        public void Fight(Enemy enemy, int potionUse = 1)
        {
            int currentStrength = GetStrength() * potionUse;
            enemy.UpdateHealth(enemy.GetHealth() - currentStrength);
            ChangeStamina(GetStamina() - 5);
            Console.WriteLine($"{enemy.Name} lost {currentStrength} health.\n");
        }

        public void AddItemToBackPack(Item item)
        {
            if (Backpack.Any(p => p.Item == item))
            {
                var backpack = Backpack.FirstOrDefault(p => p.Item == item);
                backpack.AddItems();
            }
            else Backpack.Add(new BackPack(item, 1));
        }
        public Item GetItemFromBackPack(int input)
        {
            return Backpack[input - 1].Item;
        }
        public BackPack FindBackPackItem(Item currentItem)
        {
            return Backpack.FirstOrDefault(p => p.Item == currentItem);
        }
        public void ViewBackpack()
        {
            int placement = 1;
            foreach (BackPack item in Backpack)
            {
                item.ShowItems(placement);
                placement++;
            }
            Console.WriteLine("Write a valid number to use...\n");
        }
        public bool ConfirmExistance(int input)
        {
            if (Backpack != null)
            {
                for (int i = 0; i < Backpack.Count; i++)
                {
                    int index = i + 1;
                    if (Convert.ToInt32(index) == input) return true;
                }
            }
            return false;
        }
        public void UseItem(int remove, BackPack item)
        {
            item.Amount -= remove;
            if (item.Amount == 0) Backpack.Remove(item);
        }
    }
}
