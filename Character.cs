namespace Bossfight
{
    public class Character
    {
        private string _name { get; }
        private string _status { get; }
        private int _health { get; }
        private int _strength { get; }
        private int _stamina { get; }
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
        public int GetStrength()
        {
            return _strength;
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



    }
}
