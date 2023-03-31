namespace Bossfight
{
    public class Character
    {
        private string _name { get; }
        private string _status { get; }
        private int _health { get; set; }
        private int _strength { get; }
        private int _stamina { get; set; }
        public bool _turn { get; set; }

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
            var opponent = characterList.GetOpponent();

            var newHealth = opponent._health - _strength;
            opponent._health = newHealth;
            var newStamina = _stamina - 5;
            _stamina = newStamina;
            Console.WriteLine($"{opponent._name} lost {_strength} health.");
        }

        public void Recharge(Character chosenCharacter)
        {
            if (chosenCharacter._status == "Hero") _stamina = 40;
            else _stamina = 10;
            Console.WriteLine($"Stamina recharched to {_stamina}.\n");
        }
        public bool IsDead()
        {
            if (_health == 0) return true;
            else return false;
        }
    }
}
