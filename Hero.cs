namespace Bossfight
{
    public class Hero
    {
        public string Name { get; }
        public int Health { get; set; }
        private int _strength { get; set; }
        private int _stamina { get; set; }
        public List<BackPack>? Backpack { get; set; }

        public Hero(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            _strength = strength;
            _stamina = stamina;
            Backpack = new List<BackPack>();
        }
        public int GetStamina()
        {
            return _stamina;
        }
        public int GetStrength()
        {
            return _strength;
        }
        public void ChangeStamina(int newStamina)
        {
            _stamina = newStamina;
        }
        public void Fight(Enemy enemy, int potionUse = 1)
        {
            int currentStrength = _strength * potionUse;
            enemy.Health = enemy.Health - currentStrength;
            _stamina = _stamina - 5;
            Console.WriteLine($"{enemy.Name} lost {currentStrength} health.\n");
        }
        public bool IsDead()
        {
            return Health <= 0 ? true : false;
        }
        public void GetStats()
        {
            Console.WriteLine($"{Name}\nHealth: {Health}\nStamina: {GetStamina()}\n\n");
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
            for (int i = 0; i < Backpack.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine($"{number} - {Backpack[i].Item.Name} ({Backpack[i].Amount})");
            };
            Console.WriteLine("Write the number of the potion you would like to use\nor anything else to return to menu.\n");
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
