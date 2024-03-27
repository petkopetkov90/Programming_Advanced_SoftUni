namespace Filter_By_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputCount = int.Parse(Console.ReadLine());

            List<Person> people = ReadPeoples(inputCount);

            string condition = Console.ReadLine();
            int ageThreshold = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();

            Func<Person, bool> filter = CreateFilter(condition, ageThreshold);
            Action<Person> printer = CreatePrinter(printFormat);
            PrintFilteredPeople(people, filter, printer);

        }
        private static void PrintFilteredPeople(List<Person> people, Func<Person, bool> filter, Action<Person> printer)
        {
            foreach (Person person in people)
            {
                if (filter(person))
                {
                    printer(person);
                }
            }
        }

        private static List<Person> ReadPeoples(int peopleCount)
        {
            List<Person> people = new List<Person>();

            for (int i = 0; i < peopleCount; i++)
            {
                string[] personDetails = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = personDetails[0];
                int age = int.Parse(personDetails[1]);
                Person person = new Person(name, age);
                people.Add(person);
            }

            return people;
        }

        private static Func<Person, bool> CreateFilter(string condition, int ageThreshold)
        {
            if (condition == "older")
            {
                return person => person.Age >= ageThreshold;
            }
            else
            {
                return person => person.Age < ageThreshold;
            }
        }
        private static Action<Person> CreatePrinter(object format)
        {
            switch (format)
            {
                case "name":
                    return person => Console.WriteLine(person.Name);
                case "age":
                    return person => Console.WriteLine(person.Age);
                case "name age":
                    return person => Console.WriteLine($"{person.Name} - {person.Age}");
                default:
                    return default;
            }
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
