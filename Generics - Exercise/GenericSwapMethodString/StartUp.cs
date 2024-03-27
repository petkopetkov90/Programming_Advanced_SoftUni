
using GenericSwapMethodString;

int numberOfBoxes = int.Parse(Console.ReadLine());
List<Box<string>> boxes = new List<Box<string>>();

for (int i = 0; i < numberOfBoxes; i++)
{
    boxes.Add(new Box<string>(Console.ReadLine()));
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