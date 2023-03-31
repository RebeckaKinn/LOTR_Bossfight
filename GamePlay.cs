namespace Bossfight
{
    public class GamePlay
    {

        public void StartUpLines(CharacterList ListOfCharacters)
        {
            Console.WriteLine($"Welcome to the battle between\n{ListOfCharacters.Character(0).GetName()} & {ListOfCharacters.Character(1).GetName()}");
            Console.WriteLine($"You have one action each turn.\n");
            var action = new Action();
            action.Menu();
            Start(ListOfCharacters);
        }
        public void Start(CharacterList ListOfCharacters)
        {
            var action = new Action();
            ListOfCharacters.GetStats();
            var enemyGameplay = new EnemyGameplay();
            var character = ListOfCharacters.GetCharacter();
            if (character.GetStatus() == "Hero") action.MenuChoices(character, ListOfCharacters);
            else enemyGameplay.EnemyActions(character, ListOfCharacters);
        }

        public void RechargeStamina(Character character, CharacterList ListOfCharacters)
        {
            character.Recharge(character);
            character.ChangeTurn();
            Start(ListOfCharacters);
        }

        public void FightEnemy(Character character, CharacterList ListOfCharacters)
        {
            var action = new Action();
            if (character.GetStamina() >= 0)
            {
                Console.WriteLine("You don't have enough stamina to fight! You must recharge first...");
                action.MenuChoices(character, ListOfCharacters);
            }
            else
            {
                Console.WriteLine($"{character.GetName} swings his staff and shout some magic words.");
                character.Fight(ListOfCharacters);
                CheckIfDead(character, ListOfCharacters);
                character.ChangeTurn();
                Start(ListOfCharacters);
            }
        }

        public void GameOver(Character character, CharacterList ListOfCharacters)
        {
            Console.WriteLine($"{character.GetName()} feel the ground trumble and collapse under his feet,");
            var opponent = ListOfCharacters.GetOpponent();
            Console.WriteLine($"and soon both him and {opponent.GetName()} fall down into the abyss.\n----GAME OVER----");
            Console.WriteLine("\nPress any key to restart...");
            Console.ReadKey();
            StartUpLines(ListOfCharacters);
        }

        public void Victory(Character character, CharacterList ListOfCharacters)
        {
            var opponent = ListOfCharacters.GetOpponent();
            Console.WriteLine($"Soon {character.GetName()} saw {opponent.GetName()} loose balance and got exited for a victory,");
            Console.WriteLine("but...");
            Thread.Sleep(3000);
            GameOver(character, ListOfCharacters);
        }

        public void CheckIfDead(Character character, CharacterList ListOfCharacters)
        {
            var opponent = ListOfCharacters.GetOpponent();
            if (character.IsDead()) Victory(character, ListOfCharacters);
            if (opponent.IsDead()) GameOver(character, ListOfCharacters);
        }

    }
}
