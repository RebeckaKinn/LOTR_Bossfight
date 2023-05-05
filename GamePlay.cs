namespace Bossfight
{
    public class GamePlay
    {
        public void StartUpLines()
        {
            var enemy = new Enemy("Balrog", 400, 10, 10);
            var hero = new Hero("Gandalf", 100, 15, 40);
            Console.WriteLine($"Welcome to the battle between\n{hero.Name} & {enemy.Name}");
            Console.WriteLine($"You have one action each turn.\n");
            Start(hero, enemy);
        }
        public void Start(Hero hero, Enemy enemy)
        {
            var heroAction = new HeroAction();
            var enemyAction = new EnemyAction();
            var item = new ItemList();
            while (!CheckIfDead(hero, enemy))
            {
                heroAction.Play(hero, enemy);
                CheckIfDead(hero, enemy);
                enemyAction.Play(hero, enemy);
                ItemDrop(hero, item);
            }
            GameEnd(hero, enemy);
        }
        public void ItemDrop(Hero hero, ItemList item)
        {
            var rnd = new Random();
            int chance = rnd.Next(0, 10);
            if (chance > 4)
            {
                hero.AddItemToBackPack(item.DropItem());
            }
            return;
        }
        public void GameOver(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"{hero.Name} feel the ground trumble and collapse under his feet,");
            Console.WriteLine($"and soon both him and {enemy.Name} fall down into the abyss.\n----GAME OVER----");
            Console.WriteLine("\nPress any key to restart...");
            Console.ReadKey();
            StartUpLines();
        }
        public void Victory(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"Soon {hero.Name} saw {enemy.Name} loose balance and got exited for a victory,");
            Console.WriteLine("but...");
            Thread.Sleep(3000);
            GameOver(hero, enemy);
        }
        public void GameEnd(Hero hero, Enemy enemy)
        {
            if (hero.IsDead()) Victory(hero, enemy);
            if (enemy.IsDead()) GameOver(hero, enemy);
        }
        public bool CheckIfDead(Hero hero, Enemy enemy)
        {
            if (hero.IsDead() || enemy.IsDead()) return true;
            return false;
        }
    }
}
