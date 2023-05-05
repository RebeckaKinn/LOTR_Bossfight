namespace Bossfight
{
    public class GameCharacter
    {
        public string Name { get; }
        private int _health { get; set; }
        private int _strength { get; set; }
        private int _stamina { get; set; }

        public GameCharacter(string name, int health, int strength, int stamina)
        {
            Name = name;
            _health = health;
            _strength = strength;
            _stamina = stamina;
        }
        public int GetStamina()
        {
            return _stamina;
        }
        public int GetStrength()
        {
            return _strength;
        }
        public int GetHealth()
        {
            return _health;
        }

        public void UpdateHealth(int newHealth)
        {
            _health = newHealth;
        }

        public void ChangeStamina(int newStamina)
        {
            _stamina = newStamina;
        }

        public bool IsDead() => _health <= 0;
        public virtual void GetStats()
        {
            Console.WriteLine($"{Name}\nHealth: {_health}\nStamina: {_stamina}\n\n");
        }
    }
}
