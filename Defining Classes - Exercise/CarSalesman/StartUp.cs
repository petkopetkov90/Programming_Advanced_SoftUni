using System.Dynamic;
using System.Net;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            Dictionary<string, Engine> engines = new Dictionary<string, Engine>();

            for (int i = 0; i < enginesCount; i++)
            {
                string[] engineInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine currentEngine = new Engine();
                currentEngine.Model = engineInfo[0];
                currentEngine.Power = int.Parse(engineInfo[1]);

                if (engineInfo.Length > 2)
                {
                    try
                    {
                        currentEngine.Displacement = int.Parse(engineInfo[2]);
                    }
                    catch
                    {
                        currentEngine.Efficiency = engineInfo[2];

                    }
                }
                if (engineInfo.Length > 3)
                {
                    currentEngine.Efficiency = engineInfo[3];
                }

                engines.Add(currentEngine.Model, currentEngine);
            }

            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car currentCar = new Car();
                currentCar.Model = carInfo[0];
                currentCar.Engine = engines[carInfo[1]];

                if (carInfo.Length > 2)
                {
                    try
                    {
                        currentCar.Weight = int.Parse(carInfo[2]);
                    }
                    catch
                    {
                        currentCar.Color = carInfo[2];

                    }
                }
                if (carInfo.Length > 3)
                {
                    currentCar.Color = carInfo[3];
                }

                cars.Add(currentCar);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
