namespace Bossfight
{
    public class StaminaPotion : Item
    {
        public StaminaPotion(string name, string type, int value) : base(name, type, value) { }
        public override void Use(Hero hero, Enemy enemy)
        {
            hero.ChangeStamina(GetValue());
            Console.WriteLine($"{hero.Name} drank the potion and his stamina went back up to {hero.GetStamina()}!");
        }
    }
}
