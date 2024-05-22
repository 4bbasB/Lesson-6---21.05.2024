namespace Lesson_6___21._05._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bicycle bicycle= new Bicycle();
            bicycle.Color = "Red";
            bicycle.WheelCount = 2;

            Car car= new Car();
            car.Color = "Green";
            car.WheelCount = 4;
            car.FuelCapacity = 100;
            car.FuelPerKm = 0.5;

            car.GetFullData();
            car.ShowFullData();

            bicycle.ShowFullData();
            bicycle.GetFullData();

            car.Drive(100);
        }

        
    }
}