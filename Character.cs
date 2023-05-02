namespace Bossfight
{
    public class Character
    {
        private string _name { get; }
        private string _status { get; }
        private int _health { get; set; }
        private int _strength { get; set; }
        private int _stamina { get; set; }
        public bool _turn;

        public Character(string name, string status, int health, int strength, int stamina, bool turn)
        {
            _name = name;
            _status = status;
            _health = health;
            _strength = strength;
            _stamina = stamina;
            _turn = turn;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetStatus()
        {
            return _status;
        }
        public int GetHealth()
        {
            return _health;
        }
        public int GetStamina()
        {
            return _stamina;
        }
        public bool IsTurn()
        {
            return _turn;
        }
        public void ChangeTurn()
        {
            _turn = !_turn;
        }
        public void Fight(CharacterList characterList)
        {
            var opponent = characterList.GetCharacter();
            if (_status == "Enemy")
            {
                Random number = new Random();
                _strength = number.Next(0, 30);
            }

            var newHealth = opponent._health - _strength;
            opponent._health = newHealth;
            var newStamina = _stamina - 5;
            _stamina = newStamina;
            Console.WriteLine($"{opponent.GetName()} lost {_strength} health.\n");

        }

        public void Recharge()
        {
            _stamina = 10;
            Console.WriteLine($"Stamina recharched to {_stamina}.\n");
        }
        public bool IsDead()
        {
            return _health <= 0 ? true : false;
        }

        public void UseHealthPotion()
        {
            _health = 100;
            Console.WriteLine($"{_name} drank the potion and his health went back up to {_health}!");
        }

        public void UseStaminaPotion()
        {
            _stamina = 40;
            Console.WriteLine($"{_name} drank the potion and his stamina went back up to {_stamina}!");
        }
        public void UseStrengthPotion(CharacterList characterList)
        {

            _strength = 50;
            Console.WriteLine($"{_name}s arms starts bubbling, and felt his strength grow.");
            Console.WriteLine($"Strenght has doubled to {_strength}!");
            Fight(characterList);
            _strength = 25;
        }
        public void UsePotion(int id, CharacterList characterList)
        {
            if (id == 1) UseHealthPotion();
            if (id == 2) UseStaminaPotion();
            if (id == 3) UseStrengthPotion(characterList);
        }
    }
}
