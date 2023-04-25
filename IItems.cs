namespace Bossfight
{
    public interface IItems
    {
        string Name { get; }
        int Id { get; }
        int Value { get; }

        void Use(int id, Character character);
    }
}
