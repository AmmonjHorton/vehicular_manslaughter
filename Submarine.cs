public class Submarine : Vehicle
{
    public Submarine(string name) : base(name) { }

    public override void Drive()
    {
        Console.WriteLine($"{_name} takes the Beatles on a magical journey. ");
    }
}