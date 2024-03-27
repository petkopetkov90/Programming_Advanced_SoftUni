
using GenericSwapMethodInteger;

int numberOfBoxes = int.Parse(Console.ReadLine());
List<Box<int>> boxes = new List<Box<int>>();

for (int i = 0; i < numberOfBoxes; i++)
{
    boxes.Add(new Box<int>(int.Parse(Console.ReadLine())));
}

int[] indeces = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Swap(boxes, indeces[0], indeces[1]);

foreach (var box in boxes)
{
    Console.WriteLine(box);
}

static void Swap<T>(List<T> list, int index1, int index2)
{
    (list[index1], list[index2]) = (list[index2], list[index1]);
}