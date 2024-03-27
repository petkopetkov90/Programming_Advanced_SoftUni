
using GenericBoxOfString;

int lines = int.Parse(Console.ReadLine());

List<Box<string>> boxes = new List<Box<string>>();

for (int i = 0; i < lines; i++)
{
    Box<string> box = new Box<string>(Console.ReadLine());
    boxes.Add(box);
}

for (int i = 0;i < boxes.Count; i++)
{
    Console.WriteLine(boxes[i].ToString());
}