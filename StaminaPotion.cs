namespace Bossfight
{
    public class StaminaPotion : Item
    {
        public StaminaPotion(string name, int id, string type, int value) : base(name, id, type, value)
        {

        }

        public override void Use(Hero hero, Enemy enemy)
        {
            hero.ChangeStamina(Value);
            Console.WriteLine($"{hero.Name} drank the potion and his stamina went back up to {hero.GetStamina()}!");
        }
    }
}
