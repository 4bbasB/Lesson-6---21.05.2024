namespace Lesson_6___21._05._2024
{
    public class Bicycle : Vehicle
    {
        public void ShowFullData()
        {
            Console.WriteLine($"Bicycle Color: {Color} , Wheel Count: {WheelCount}");
        }

        public string GetFullData() 
        {

            return $"Bicycle Color: {Color} , Wheel Count: {WheelCount}";
        }
    }
}
