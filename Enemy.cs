namespace Bossfight
{
    public class Enemy
    {
        public string Name { get; }
        public int Health { get; set; }
        private int _strength { get; set; }
        private int _stamina { get; set; }
        public Enemy(string name, int health, int strength, int stamina)
        {
            Name = name;
            Health = health;
            _strength = strength;
            _stamina = stamina;
        }
        public Enemy()
        {
            new Enemy("Balrog", 400, 10, 10);
        }
        public int GetHealth()
        {
            return Health;
        }
        public int GetStamina()
        {
            return _stamina;
        }
        public int GetStrength()
        {
            return _strength;
        }

        public void ChangeHealth(int newHealth)
        {
            Health = newHealth;
        }
        public void Fight(Hero hero)
        {
            Random number = new Random();
            _strength = number.Next(0, 30);
            hero.Health = hero.Health - _strength;
            _stamina = _stamina - 5;
            Console.WriteLine($"{hero.Name} lost {_strength} health.\n");
        }
        public void Recharge()
        {
            _stamina = 10;
            Console.WriteLine($"Stamina recharched to {_stamina}.\n");
        }
        public bool IsDead()
        {
            return Health <= 0 ? true : false;
        }
        public void GetStats()
        {
            Console.WriteLine($"{Name}\nHealth: {Health}\nStamina: {GetStamina()}\n\n");
        }
    }
}
