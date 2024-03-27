
using CustomDoublyLinkedList;

DoublyLinkedList<int> linkedList = new DoublyLinkedList<int>();
linkedList.AddFirst(1);
linkedList.AddFirst(2);
linkedList.AddFirst(3);
linkedList.AddFirst(4);
linkedList.AddLast(5);
linkedList.AddLast(6);
linkedList.RemoveLast();
linkedList.RemoveLast();
linkedList.RemoveFirst();

linkedList.ForEach(node => Console.WriteLine(node));
Console.WriteLine(linkedList.Count);

int[] array = linkedList.ToArray();

Console.WriteLine(string.Join(", ", array));

Console.WriteLine(linkedList.Join(" "));

Console.WriteLine($"{linkedList.Contains(12)}");
Console.WriteLine($"{linkedList.Contains(1)}");

linkedList.Clear();

Console.WriteLine(linkedList.Count);

Console.WriteLine($"{linkedList.Contains(1)}");

