namespace Implement_the_CustomQueue_Class
{
    internal class StartUp
    {
        static void Main()
        {
            CustomQueue queue = new CustomQueue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            Console.WriteLine(queue.Count);

            queue.Dequeue();
            queue.Dequeue();
            queue.Enqueue(6);

            queue.ForEach(x => Console.WriteLine(x));

            queue.Clear();

            Console.WriteLine(queue.Count);


        }
    }
}
