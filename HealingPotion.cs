namespace Bossfight
{
    public class HealingPotion : Item
    {
        public HealingPotion(string name, int id, string type, int value) : base(name, id, type, value)
        {

        }

        public override void Use(Hero hero, Enemy enemy)
        {
            hero.Health = Value;
            Console.WriteLine($"{hero.Name} drank the potion and his health went up to {hero.Health}!");
        }
    }
}
