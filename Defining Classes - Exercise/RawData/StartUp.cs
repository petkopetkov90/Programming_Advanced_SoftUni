namespace RawData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = carInfo[0];
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                double tire1Pressure = double.Parse(carInfo[5]);
                int tire1Age = int.Parse(carInfo[6]);
                double tire2Pressure = double.Parse(carInfo[7]);
                int tire2Age = int.Parse(carInfo[8]);
                double tire3Pressure = double.Parse(carInfo[9]);
                int tire3Age = int.Parse(carInfo[10]);
                double tire4Pressure = double.Parse(carInfo[11]);
                int tire4Age = int.Parse(carInfo[12]);


                Tire[] currentTires = new Tire[]
                {
                    new Tire(tire1Pressure,tire1Age),
                    new Tire(tire2Pressure,tire2Age),
                    new Tire(tire3Pressure,tire3Age),
                    new Tire(tire4Pressure,tire4Age),
                };

                Cargo currentCargo = new Cargo(cargoWeight, cargoType);

                Engine currentEngine = new Engine(engineSpeed, enginePower);

                Car currentCar = new Car(model, currentEngine, currentCargo, currentTires);

                cars.Add(currentCar);
            }

            string cargoTypeSorter = Console.ReadLine();

            Predicate<Car> sorter = GetPredicate(cargoTypeSorter);

            cars = cars.FindAll(sorter);

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Model);
            }
        }

        private static Predicate<Car> GetPredicate(string cargoTypeSorter)
        {
            if (cargoTypeSorter == "fragile")
            {
                return car => car.Cargo.Type == cargoTypeSorter && car.Tires.Any(t => t.Pressure < 1);
            }
            else if (cargoTypeSorter == "flammable")
            {
                return car => car.Cargo.Type == cargoTypeSorter && car.Engine.Power > 250;
            }

            return default;
        }
    }
}
