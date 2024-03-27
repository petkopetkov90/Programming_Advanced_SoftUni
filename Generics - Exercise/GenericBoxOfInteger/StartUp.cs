
using GenericBoxOfInteger;

int lines = int.Parse(Console.ReadLine());

List<Box<int>> boxes = new List<Box<int>>();

for (int i = 0; i < lines; i++)
{
    Box<int> box = new Box<int>(int.Parse(Console.ReadLine()));
    boxes.Add(box);
}

for (int i = 0; i < boxes.Count; i++)
{
    Console.WriteLine(boxes[i].ToString());
}