namespace Bossfight
{
    public class Action
    {
        public void Menu(Character caracter, CharacterList ListOfCharacters)
        {
            ListOfCharacters.GetStats();
            Console.WriteLine("What do you do?");
            Console.WriteLine("1 - Fight\n2 - Use Potion\n3 - Flee");
            MenuChoices(caracter, ListOfCharacters);
        }

        public void MenuChoices(Character character, CharacterList ListOfCharacters)
        {
            var item = new ItemList();
            var gameplay = new GamePlay();
            var input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    gameplay.FightEnemy(character, ListOfCharacters);
                    break;
                case "2":
                    ItemMenu(character, item);
                    break;
                case "3":
                    Console.WriteLine($"'Fly, you fools!' {character.GetName()} said.");
                    gameplay.GameOver(character, ListOfCharacters);
                    break;
                default:
                    MenuChoices(character, ListOfCharacters);
                    break;
            }
        }
        public void ItemMenu(Character character, ItemList item)
        {
            Console.WriteLine("Which potion would you like to drink?");
            item.ScrollThroughItems();
            var input = Console.ReadLine();
            item.UseItem(input, character);
        }
    }
}
