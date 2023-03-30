﻿namespace Bossfight
{
    public class GamePlay
    {
        public void StartUpLines(CharacterList ListOfCharacters)
        {
            Console.WriteLine($"Welcome to the battle between\n{ListOfCharacters.Character(0).GetName()} & {ListOfCharacters.Character(1).GetName()}");
            Console.WriteLine($"You have one action each turn.");
            var action = new Action();
            action.Menu();
            Start(ListOfCharacters, action);
        }
        public void Start(CharacterList ListOfCharacters, Action action)
        {
            var character = ListOfCharacters.GetCharacter();
            action.MenuChoices(character, ListOfCharacters);
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

    }
}