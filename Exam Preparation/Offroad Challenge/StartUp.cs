
Stack<int> fuelQuantities = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> additionsConsumptionIndices = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> altitudeQuantities = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int levelReached = 1;

List<string> altitudesReached = new List<string>();

while (true)
{
    int fuel = fuelQuantities.Pop();
    int consumptionIndex = additionsConsumptionIndices.Dequeue();
    int fuelResult = fuel - consumptionIndex;
    int fuelNeed = altitudeQuantities.Dequeue();

    if (fuelResult < fuelNeed)
    {
        Console.WriteLine($"John did not reach: Altitude {levelReached}");
        Console.WriteLine("John failed to reach the top.");

        if (levelReached == 1)
        {
            Console.WriteLine("John didn't reach any altitude.");
        }
        else
        {
            Console.WriteLine($"Reached altitudes: {string.Join(", ", altitudesReached)}");
        }

        break;
    }

    Console.WriteLine($"John has reached: Altitude {levelReached}");
    altitudesReached.Add($"Altitude {levelReached}");
    levelReached++;

    if (altitudeQuantities.Count == 0)
    {
        Console.WriteLine("John has reached all the altitudes and managed to reach the top!"); ;
        break;
    }
}