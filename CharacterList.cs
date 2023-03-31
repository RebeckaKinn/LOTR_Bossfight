namespace Bossfight
{
    public class CharacterList
    {
        public List<Character> ListOfCharacters { get; set; }

        public CharacterList()
        {
            ListOfCharacters = new List<Character>
            {
                new Character("Gandalf", "Hero", 100, 20, 40, false),
                new Character("Balrog", "Enemy", 400, 20, 10, true)
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

        public Character GetOpponent()
        {
            var opponent = ListOfCharacters[0];
            foreach (Character character in ListOfCharacters)
            {
                if (!character.IsTurn()) opponent = character;
            }
            return opponent;
        }
    }
}
