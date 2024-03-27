
Stack<int> amountOfMoney = new Stack<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

Queue<int> pricesOfFood = new Queue<int>(Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse));

int foodEaten = 0;

while (amountOfMoney.Any() && pricesOfFood.Any())
{
    int money = amountOfMoney.Pop();
    int foodPirce = pricesOfFood.Dequeue();

    if (money == foodPirce)
    {
        foodEaten++;
        continue;
    }
    else if (money > foodPirce)
    {
        foodEaten++;
        money -= foodPirce;

        if (amountOfMoney.Any())
        {
            money += amountOfMoney.Pop();
        }
        amountOfMoney.Push(money);
    }
}

if (foodEaten >= 4)
{
    Console.WriteLine($"Gluttony of the day! Henry ate {foodEaten} foods.");
}
else if (foodEaten > 1)
{
    Console.WriteLine($"Henry ate: {foodEaten} foods.");
}
else if (foodEaten == 1)
{
    Console.WriteLine($"Henry ate: {foodEaten} food.");
}
else if (foodEaten == 0)
{
    Console.WriteLine("Henry remained hungry. He will try next weekend again.");
}