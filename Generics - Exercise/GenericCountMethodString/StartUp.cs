
using GenericCountMethodString;

int inputCount = int.Parse(Console.ReadLine());

List<Box<string>> boxes = new List<Box<string>>();

for (int i = 0; i < inputCount; i++)
{
    string element = Console.ReadLine();
    boxes.Add(new Box<string>(element));
}

string elementToCompareWith = Console.ReadLine();

Console.WriteLine(Compare(boxes, elementToCompareWith));

int Compare<T>(List<Box<T>> list, T elementToCompareWith) where T : IComparable<T>
{
    int count = 0;

    foreach (var box in list)
    {
        if (box.Value.CompareTo(elementToCompareWith) == 1)
        {
            count++;
        }
    }

    return count;
}