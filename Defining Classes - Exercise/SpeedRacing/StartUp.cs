namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] carDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carDetails[0];
                double fuelAmount = double.Parse(carDetails[1]);
                double fuelConsumptionPerKilometer = double.Parse(carDetails[2]);
                Car car = new Car();
                car.Model = model;
                car.FuelAmount = fuelAmount;
                car.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;

                if (!cars.ContainsKey(model))
                {
                    cars.Add(model, car);
                }

            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] driveDetails = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string carModel = driveDetails[1];
                double distance = double.Parse(driveDetails[2]);

                cars[carModel].Drive(distance);
            }

            foreach (Car car in cars.Values)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
