namespace Bossfight
{
    public class HealingPotion : Item
    {
        public HealingPotion(string name, string type, int value) : base(name, type, value) { }
        public override void Use(Hero hero, Enemy enemy)
        {
            hero.UpdateHealth(GetValue());
            Console.WriteLine($"{hero.Name} drank the potion and his health went up to {hero.GetHealth()}!");
        }
    }
}
