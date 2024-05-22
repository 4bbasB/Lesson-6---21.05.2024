namespace Lesson_6___21._05._2024
{
    public class Car : Vehicle
    {
        public double FuelCapacity;
        public double FuelPerKm;
        public void ShowFullData()
        {
            Console.WriteLine($"Car Color: {Color} , Wheel Count: {WheelCount}, FuelCapacity: {FuelCapacity}, Fuel per km: {FuelPerKm}");
        }

        public string GetFullData()
        {

            return $"Car Color: {Color} , Wheel Count: {WheelCount}, FuelCapacity: {FuelCapacity}, Fuel per km: {FuelPerKm}";
        }

        public void Drive(int km)
        {
            FuelCapacity = FuelCapacity - (km * FuelPerKm);
            Console.WriteLine(FuelCapacity);
        }
    }
}
