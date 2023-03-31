namespace Bossfight
{
    internal class EnemyGameplay
    {
        public void EnemyActions(Character character, CharacterList ListOfCharacters)
        {
            var startGame = new GamePlay();
            if (character.GetStamina() >= 0)
            {
                Console.WriteLine($"{character.GetName()} is really tired and need a moment to catch his breath");
                character.Recharge(character);
                startGame.Start(ListOfCharacters);
            }
            else
            {
                Console.WriteLine($"{character.GetName()} growls loudely and shouts a firey breath at you!");
                character.Fight(ListOfCharacters);
                startGame.CheckIfDead(character, ListOfCharacters);
                startGame.Start(ListOfCharacters);
            }
        }
    }
}
