
using GenericCountMethodDouble;

int inputCount = int.Parse(Console.ReadLine());

List<Box<double>> boxes = new List<Box<double>>();

for (int i = 0; i < inputCount; i++)
{
    double element = double.Parse(Console.ReadLine());
    boxes.Add(new Box<double>(element));
}

double elementToCompareWith = double.Parse(Console.ReadLine());

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