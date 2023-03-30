namespace Bossfight
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var characterList = new CharacterList();
            var startGame = new GamePlay();
            startGame.StartUpLines(characterList);
        }
    }
}