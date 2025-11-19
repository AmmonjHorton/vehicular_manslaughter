// Create a class here that is a child of the Vehicle class.
// This class should implement a Boat and override the Drive 
// method.
public class Boat : Vehicle
{
    public Boat(string name) : base(name) { }

    public override void Drive()
    {
        Console.WriteLine($"{_name} swims quite nicely!");
    }
}