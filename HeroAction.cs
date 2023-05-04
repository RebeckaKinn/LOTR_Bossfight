namespace Bossfight
{
    public class HeroAction
    {
        public void Play(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"\nIt is now {hero.Name}'s turn.");
            Menu(hero, enemy);
            MenuChoices(hero, enemy);
        }
        public void Menu(Hero hero, Enemy enemy)
        {
            hero.GetStats();
            enemy.GetStats();
            Console.WriteLine("What do you do?");
            Console.WriteLine("1 - Fight\n2 - View Backpack\n3 - Flee");
        }

        public void MenuChoices(Hero hero, Enemy enemy)
        {
            var gameplay = new GamePlay();
            var input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1":
                    FightEnemy(hero, enemy);
                    break;
                case "2":
                    ItemMenu(hero, enemy);
                    break;
                case "3":
                    Console.WriteLine($"'Fly, you fools!' {hero.Name} said.");
                    gameplay.GameOver(hero, enemy);
                    break;
                default:
                    MenuChoices(hero, enemy);
                    break;
            }
        }
        public void ItemMenu(Hero hero, Enemy enemy)
        {
            if (hero.Backpack == null)
            {
                Console.WriteLine("Your backpack is empty!");
                FightEnemy(hero, enemy);
                return;
            }
            Console.WriteLine("Backpack:");
            hero.ViewBackpack();
            var input = Console.ReadLine();
            if (hero.ConfirmExistance(Convert.ToInt32(input)))
            {
                hero.FindItemFronBackPack(Convert.ToInt32(input)).Use(hero, enemy);
                hero.UseItem(1, hero.FindBackPackItem(hero.FindItemFronBackPack(Convert.ToInt32(input))));
            }
            else Menu(hero, enemy);
        }

        public void FightEnemy(Hero hero, Enemy enemy)
        {
            var action = new HeroAction();
            if (hero.GetStamina() == 0)
            {
                Console.WriteLine("You don't have enough stamina to fight! You must recharge first...");
                action.Menu(hero, enemy);
            }
            else
            {
                Console.WriteLine($"{hero.Name} swings his staff and shout some magic words.");
                hero.Fight(enemy);
            }
        }
    }
}
