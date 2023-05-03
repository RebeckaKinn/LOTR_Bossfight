namespace Bossfight
{
    public class EnemyAction
    {
        public void Play(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"\nIt is now {enemy.Name}'s turn.");
            if (enemy.GetStamina() == 0)
            {
                Console.WriteLine($"{enemy.Name} is really tired and need a moment to catch his breath");
                enemy.Recharge();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"{hero.Name} growls loudely and shouts a firey breath at you!");
                enemy.Fight(hero);
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
