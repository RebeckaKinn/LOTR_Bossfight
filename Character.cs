namespace Bossfight
{
    internal class Character
    {
        private string Name { get; }
        private string Status { get; }
        private int Health { get; }
        private int Strength { get; }
        private int Stamina { get; }

        public Character(string name, string status, int health, int strength, int stamina)
        {
            Name = name;
            Status = status;
            Health = health;
            Strength = strength;
            Stamina = stamina;
        }

    }
}
