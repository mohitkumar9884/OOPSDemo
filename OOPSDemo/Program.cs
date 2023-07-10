namespace OOPSDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car car1 = new Car();
            car1.model = "Mustang";
            car1.colour = "Matt Black";
            car1.price = 7500000;
            car1.CarDetails();

            Car car2 = new Car();
            car2.model = "Merc";
            car2.colour = "Jupiter Red";
            car2.price = 7000000;
            car2.CarDetails();

        }
    }
}