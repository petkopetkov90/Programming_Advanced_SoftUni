namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] currentPerson = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = currentPerson[0],
                    Age = int.Parse(currentPerson[1])
                };

                family.AddMember(person);
            }

            Person oldestFamilyMember = family.GetOldestMember();

            Console.WriteLine($"{oldestFamilyMember.Name} {oldestFamilyMember.Age}");
        }
    }
}
