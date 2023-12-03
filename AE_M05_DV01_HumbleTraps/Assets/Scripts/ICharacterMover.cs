public interface ICharacterMover
{
    int Health { get; set; }

    int Strength { get; set; }
    bool IsPlayer { get; }
}