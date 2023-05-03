namespace Bossfight
{
    public class Hero
    {
        public string Name { get; }
        public int Health { get; set; }
        private int _strength { get; set; }
        private int _stamina { get; set; }
        public List<BackPack> Backpack { get; set; }

        public Hero(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            _strength = strength;
            _stamina = stamina;
        }

        public Hero()
        {
            new Hero("Gandalf", 100, 25, 40);
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
        public void Fight(Enemy enemy)
        {
            enemy.Health = enemy.Health - _strength;
            _stamina = _stamina - 5;
            Console.WriteLine($"{enemy.Name} lost {_strength} health.\n");

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
            var newItem = new BackPack(item, 1);
            Backpack.Add(newItem);
        }




        public Item FindPotionFronBackPack(int id)
        {
            var backpackMatch = Backpack.FirstOrDefault(p => p.Item.Id == id);
            var usedItem = backpackMatch?.Item;
            return usedItem;
        }

        public void ViewBackpack()
        {
            for (int i = 0; i < Backpack.Count; i++)
            {
                int number = i + 1;
                Console.WriteLine($"{number} - {Backpack[i].Item.Name} ({Backpack[i].Amount})");
            };
        }
        public bool ConfirmID(int input)
        {
            return Backpack.Any(p => p.Item.Id == input);
        }

        public bool IsItemInInventory(int index)
        {
            for (int i = 1; i < Backpack.Count; i++)
            {
                if (i == index) return true;
                break;
            }
            return false;
        }
    }
}
