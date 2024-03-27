namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tiresInfo = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] currentTires = new Tire[]
                {
                    new Tire(int.Parse(tiresInfo[0]), double.Parse(tiresInfo[1])),
                    new Tire(int.Parse(tiresInfo[2]), double.Parse(tiresInfo[3])),
                    new Tire(int.Parse(tiresInfo[4]), double.Parse(tiresInfo[5])),
                    new Tire(int.Parse(tiresInfo[6]), double.Parse(tiresInfo[7]))
                };

                tires.Add(currentTires);
            }

            List<Engine> engines = new List<Engine>();

            input = string.Empty;
            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Engine currentEngine = new Engine(int.Parse(engineDetails[0]), double.Parse(engineDetails[1]));
                engines.Add(currentEngine);
            }

            List<Car> cars = new List<Car>();

            input = string.Empty;
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car currentCar = new Car(carDetails[0],
                    carDetails[1],
                    int.Parse(carDetails[2]),
                    double.Parse(carDetails[3]),
                    double.Parse(carDetails[4]),
                    engines[int.Parse(carDetails[5])],
                    tires[int.Parse(carDetails[6])]);

                cars.Add(currentCar);
            }

            Predicate<double> tiresPressure = sum => sum <= 10 && sum >= 9;

            cars = cars.FindAll(c => c.Year >= 2017 && c.Engine.HorsePower > 330 && tiresPressure(c.Tires.Sum(t => t.Pressure)));
            cars.ForEach(car => car.Drive(20));

            foreach (Car specialCar in cars)
            {
                Console.WriteLine($"Make: {specialCar.Make}");
                Console.WriteLine($"Model: {specialCar.Model}");
                Console.WriteLine($"Year: {specialCar.Year}");
                Console.WriteLine($"HorsePowers: {specialCar.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {specialCar.FuelQuantity}");
            }
        }
    }

}

