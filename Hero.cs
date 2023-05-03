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

        public void AddItemToBackPack(object item)
        {
            var newItem = new BackPack(item, 1);
            Backpack.Add(newItem);
        }






        public void ViewBackpack()
        {

        }
        public bool ConfirmID(int input)
        {
            return Backpack.Any(p => p.Id == input);
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
