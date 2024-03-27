namespace Implement_the_CustomList_Class
{
    internal class StartUp
    {
        static void Main()
        {
            CustomList list = new CustomList();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            list.RemoveAt(1);

            Console.WriteLine($"{list.Contains(2)}");
            Console.WriteLine($"{list.Contains(5)}");

            Console.WriteLine(list.Count);

            list.Swap(2,3);

            list.Insert(1, 6);

            Console.WriteLine(list.Count);

            list[0] = 9;

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
