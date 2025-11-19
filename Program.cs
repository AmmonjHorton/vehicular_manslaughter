namespace cse210_unit05_ta;

class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Car("Ford");
        car.Drive();

        // TODO: Instantiate a Boat, an Airplane, and a Motorcycle
        Vehicle boat = new Boat("Jackdaw");
        boat.Drive();
        Vehicle se = new SiegeEngine("Battering ram");
        se.Drive();
        Vehicle sub = new Submarine("Yellow Submarine");
        sub.Drive();

        // TODO: Create a list to hold multiple vehicles and call .Drive() on each one
        List<Vehicle> vehicles = new List<Vehicle> { car, boat, se, sub };
        foreach (Vehicle v in vehicles)
        {
            v.Drive();
        }

    }
}
