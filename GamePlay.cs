namespace Bossfight
{
    public class GamePlay
    {
        public void Start(CharacterList ListOfCharacters)
        {
            ChangeTurn(ListOfCharacters);
        }

        public void ChangeTurn(CharacterList ListOfCharacters)
        {
            var character = ListOfCharacters.GetCharacter();
            Console.WriteLine($"{character.GetName()}");

        }
    }
}
