namespace Bossfight
{
    public class Enemy : GameCharacter
    {
        public Enemy(string name, int health, int strength, int stamina) : base(name, health, strength, stamina)
        {

        }
        public void Fight(Hero hero)
        {
            Random strength = new Random();
            int currentStrength = strength.Next(0, 30);
            hero.UpdateHealth(hero.GetHealth() - currentStrength);
            ChangeStamina(GetStamina() - 5);
            Console.WriteLine($"{hero.Name} lost {currentStrength} health.\n");
        }
        public void Recharge()
        {
            ChangeStamina(10);
            Console.WriteLine($"Stamina recharched to {GetStamina()}.\n");
        }
    }
}
