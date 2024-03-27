namespace Crossroads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenLightTime = int.Parse(Console.ReadLine());
            int freeWindowTime = int.Parse(Console.ReadLine());
            Queue<string> carsQueue = new Queue<string>();
            int carsPassed = 0;
            bool isHit = false;
            string car;
            while ((car = Console.ReadLine()) != "END")
            {
                int currentGreenTime = greenLightTime;
                if (car != "green")
                {
                    carsQueue.Enqueue(car);
                    continue;
                }

                while (currentGreenTime > 0 && carsQueue.Count > 0)
                {
                    string currentCar = carsQueue.Dequeue();
                    currentGreenTime -= currentCar.Length;
                    if (currentGreenTime + freeWindowTime < 0)
                    {
                        int indexOfHit = currentCar.Length - Math.Abs(currentGreenTime + freeWindowTime);
                        Console.WriteLine("A crash happened!");
                        Console.WriteLine($"{currentCar} was hit at {currentCar[indexOfHit]}.");
                        isHit = true;
                        break;
                    }
                    carsPassed++;
                }

                if (isHit)
                {
                    break;
                }
            }

            if (!isHit)
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carsPassed} total cars passed the crossroads.");
            }
        }
    }
}
