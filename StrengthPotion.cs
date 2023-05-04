namespace Bossfight
{
    public class StrengthPotion : Item
    {
        public StrengthPotion(string name, int id, string type, int value) : base(name, id, type, value)
        {

        }
        public override void Use(Hero hero, Enemy enemy)
        {
            //cannot use this in battle yet
            int newStrength = hero.GetStrength() * Value;
            Console.WriteLine($"{hero.Name}s arms starts bubbling, and felt his strength grow.");
            Console.WriteLine($"Strenght has doubled to {hero.GetStrength()}!");
            hero.Fight(enemy);
        }
    }
}
