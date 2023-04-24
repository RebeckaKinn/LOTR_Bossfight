namespace Bossfight
{
    public class GamePlay
    {

        public void StartUpLines()
        {
            var characterList = new CharacterList();
            Console.WriteLine($"Welcome to the battle between\n{characterList.Character(0).GetName()} & {characterList.Character(1).GetName()}");
            Console.WriteLine($"You have one action each turn.\n");
            Start(characterList);
        }
        public void Start(CharacterList ListOfCharacters)
        {
            var item = new ItemList();
            var action = new Action();
            var character = ListOfCharacters.GetCharacter();
            ListOfCharacters.ChangeTurn();
            var enemyGameplay = new EnemyGameplay();
            Console.WriteLine($"\nIt is now {character.GetName()}'s turn.");
            if (character.GetStatus() == "Hero") action.Menu(character, ListOfCharacters, item);
            else enemyGameplay.EnemyActions(character, ListOfCharacters);
        }

        public void RechargeStamina(Character character, CharacterList ListOfCharacters)
        {
            character.Recharge(character);
            Start(ListOfCharacters);
        }

        public void FightEnemy(Character character, CharacterList ListOfCharacters)
        {
            var action = new Action();
            if (character.GetStamina() == 0)
            {
                Console.WriteLine("You don't have enough stamina to fight! You must recharge first...");
                action.Menu(character, ListOfCharacters);
            }
            else
            {
                Console.WriteLine($"{character.GetName()} swings his staff and shout some magic words.");
                character.Fight(ListOfCharacters);
                CheckIfDead(character, ListOfCharacters);
                Start(ListOfCharacters);
            }
        }

        public void GameOver(Character character, CharacterList ListOfCharacters)
        {
            Console.WriteLine($"{character.GetName()} feel the ground trumble and collapse under his feet,");
            var opponent = ListOfCharacters.GetCharacter();
            Console.WriteLine($"and soon both him and {opponent.GetName()} fall down into the abyss.\n----GAME OVER----");
            Console.WriteLine("\nPress any key to restart...");
            Console.ReadKey();
            StartUpLines();
        }

        public void Victory(Character character, CharacterList ListOfCharacters)
        {
            var opponent = ListOfCharacters.GetCharacter();
            Console.WriteLine($"Soon {character.GetName()} saw {opponent.GetName()} loose balance and got exited for a victory,");
            Console.WriteLine("but...");
            Thread.Sleep(3000);
            GameOver(character, ListOfCharacters);
        }

        public void CheckIfDead(Character character, CharacterList ListOfCharacters)
        {
            var opponent = ListOfCharacters.GetCharacter();
            if (character.IsDead()) Victory(character, ListOfCharacters);
            if (opponent.IsDead()) GameOver(character, ListOfCharacters);
        }

    }
}
