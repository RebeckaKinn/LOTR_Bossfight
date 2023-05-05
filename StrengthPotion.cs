namespace Bossfight
{
    public class StrengthPotion : Item
    {
        public StrengthPotion(string name, int id, string type, int value) : base(name, id, type, value)
        {

        }
        public override void Use(Hero hero, Enemy enemy)
        {
            Console.WriteLine($"{hero.Name}s arms starts bubbling, and felt his strength grow.");
            Console.WriteLine($"Strenght has doubled to {hero.GetStrength() * Value}!");
            hero.Fight(enemy, Value);
        }
    }
}
