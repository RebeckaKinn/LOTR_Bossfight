namespace Bossfight
{
    public class StrengthPotion : Item
    {
        public StrengthPotion(string name, string type, int value) : base(name, type, value) { }
        public override void Use(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"{hero.Name}s arms starts bubbling, and felt his strength grow.");
            Console.WriteLine($"Strenght has doubled to {hero.GetStrength() * GetValue()}!");
            hero.Fight(enemy, GetValue());
        }
    }
}
