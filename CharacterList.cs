namespace Bossfight
{
    public class CharacterList
    {
        private List<Character> ListOfCharacters { get; set; }

        public CharacterList()
        {
            ListOfCharacters = new List<Character>
            {
                new Character("Gandalf", "Hero", 100, 20, 40),
                new Character("Balrog", "Enemy", 400, 20, 10)
            };
        }

    }
}
