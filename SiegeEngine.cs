public class SiegeEngine : Vehicle
{
    public SiegeEngine(string name) : base(name) { }

    public override void Drive()
    {
        Console.WriteLine($"{_name} topples a tower! ");
    }
}