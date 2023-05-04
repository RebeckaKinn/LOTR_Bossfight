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
            if (Backpack.Any(p => p.Item == item))
            {
                var backpack = Backpack.FirstOrDefault(p => p.Item == item);
                backpack.AddItems();
            }
            else Backpack.Add(new BackPack(item, 1));
        }

        //wrong, not use id, use index. Fix where ID is used in this context. 
        public Item FindItemFronBackPack(int input)
        {
            return Backpack[input - 1].Item;
            //for (int i = 1; i < Backpack?.Count; i++)
            //{
            //    if (i == input)
            //    {
            //        return Backpack[i]?.Item;
            //    }
            //}
            //return Backpack[input].Item;
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
        }
        public bool ConfirmExistance(int input)
        {
            for (int i = 1; i < Backpack?.Count; i++)
            {
                if (i == input) return true;
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
