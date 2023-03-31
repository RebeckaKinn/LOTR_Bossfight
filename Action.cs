namespace Bossfight
{
    public class Action
    {
        public void Menu(Character caracter, CharacterList ListOfCharacters)
        {
            ListOfCharacters.GetStats();
            Console.WriteLine("What do you do?");
            Console.WriteLine("1 - Fight\n2 - Recharge\n3 - Flee");
            MenuChoices(caracter, ListOfCharacters);
        }

        public void MenuChoices(Character caracter, CharacterList ListOfCharacters)
        {
            var gameplay = new GamePlay();
            var input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    gameplay.FightEnemy(caracter, ListOfCharacters);
                    break;
                case "2":
                    gameplay.RechargeStamina(caracter, ListOfCharacters);
                    break;
                case "3":
                    gameplay.GameOver(caracter, ListOfCharacters);
                    break;
                default:
                    MenuChoices(caracter, ListOfCharacters);
                    break;
            }
        }
    }
}
