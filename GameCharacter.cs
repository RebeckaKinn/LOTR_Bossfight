namespace Bossfight
{
    public class GameCharacter
    {
        public string Name { get; }
        public int Health { get; set; }
        private int _strength { get; set; }
        private int _stamina { get; set; }

        public GameCharacter(string name, int health, int strength, int stamina)
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
        public int GetStrength()
        {
            return _strength;
        }

        public void ChangeStamina(int newStamina)
        {
            _stamina = newStamina;
        }

        public bool IsDead() => Health <= 0;
        public virtual void GetStats()
        {
            Console.WriteLine($"{Name}\nHealth: {Health}\nStamina: {_stamina}\n\n");
        }
    }
}
