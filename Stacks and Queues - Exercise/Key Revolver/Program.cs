namespace Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pricePerBullet = int.Parse(Console.ReadLine());
            int gunBarrel = int.Parse(Console.ReadLine());
            int[] bulletsArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] locksArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int intelligenceValue = int.Parse(Console.ReadLine());

            Stack<int> bullets = new Stack<int>(bulletsArray);
            Queue<int> locks = new Queue<int>(locksArray);

            int currentBarrel = gunBarrel;
            int bulletsShooted = 0;

            while (bullets.Count > 0 && locks.Count > 0)
            {
                int currentBullet = bullets.Pop();
                bulletsShooted++;
                int currentLock = locks.Peek();
                if (currentLock >= currentBullet)
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                currentBarrel--;

                if (currentBarrel == 0 && bullets.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    currentBarrel = gunBarrel;
                }
            }

            if (bullets.Count == 0 && locks.Count > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                int moneyEarned = intelligenceValue - (bulletsShooted * pricePerBullet);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${moneyEarned}");
            }
        }
    }
}
