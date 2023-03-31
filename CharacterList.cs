namespace Bossfight
{
    public class CharacterList
    {
        public List<Character> ListOfCharacters { get; set; }

        public CharacterList()
        {
            ListOfCharacters = new List<Character>
            {
                new Character("Gandalf", "Hero", 100, 20, 40, true),
                new Character("Balrog", "Enemy", 400, 10, 10, false)
            };
        }

        public Character GetCharacter()
        {
            Character currentCharacter = ListOfCharacters[0];
            foreach (Character character in ListOfCharacters)
            {
                if (character.IsTurn()) currentCharacter = character;
            }
            return currentCharacter;
        }

        public void ChangeTurn()
        {
            foreach (Character character in ListOfCharacters)
            {
                character.ChangeTurn();
            }
        }

        public Character Character(int index)
        {
            return ListOfCharacters[index];
        }
        public void GetStats()
        {
            foreach (Character character in ListOfCharacters)
            {
                Console.WriteLine($"{character.GetName()}\nHealth: {character.GetHealth()}\nStamina: {character.GetStamina()}\n\n");
            }
        }
    }
}
