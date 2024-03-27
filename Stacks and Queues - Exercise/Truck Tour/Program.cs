namespace Truck_Tour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfFuelStations = int.Parse(Console.ReadLine());
            Queue<(int, int)> fuelStations = new Queue<(int, int)>();

            for (int i = 0; i < numberOfFuelStations; i++)
            {
                int[] fuelStation = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                fuelStations.Enqueue((fuelStation[0], fuelStation[1]));
            }

            int bestIndex = 0;
            int currentFuel = 0;
            int stationsPassed = 0;

            while (true)
            {
                currentFuel += fuelStations.Peek().Item1;
                int kmToPass = fuelStations.Peek().Item2;

                if (currentFuel >= kmToPass)
                {
                    currentFuel -= kmToPass;
                    stationsPassed++;
                }
                else
                {
                    currentFuel = 0;
                    bestIndex += stationsPassed;
                    bestIndex++;
                    stationsPassed = 0;
                }

                if (stationsPassed == numberOfFuelStations)
                {
                    break;
                }

                fuelStations.Enqueue(fuelStations.Dequeue());
            }

            Console.WriteLine(bestIndex);
        }
    }
}

