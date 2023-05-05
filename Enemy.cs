namespace Bossfight
{
    public class Enemy
    {
        public string Name { get; }
        public int Health { get; set; }
        private Random _strength { get; set; }
        private int _stamina { get; set; }
        public Enemy(string name, int health, Random strength, int stamina)
        {
            Name = name;
            Health = health;
            _strength = strength;
            _stamina = stamina;
        }
        public int GetStamina()
        {
            return _stamina;
        }
        public void Fight(Hero hero)
        {
            int currentStrength = _strength.Next(0, 30);
            hero.Health = hero.Health - currentStrength;
            _stamina = _stamina - 5;
            Console.WriteLine($"{hero.Name} lost {currentStrength} health.\n");
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
