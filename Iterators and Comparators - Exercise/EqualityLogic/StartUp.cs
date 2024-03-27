
using EqualityLogic;

SortedSet<Person> sortedPeople = new SortedSet<Person>();
HashSet<Person> people = new HashSet<Person>();

int totalPersons = int.Parse(Console.ReadLine());

for (int i = 0; i < totalPersons; i++)
{
    string[] personDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = personDetails[0];
    int age = int.Parse(personDetails[1]);

    Person person = new Person(name, age);

    sortedPeople.Add(person);
    people.Add(person);
}

Console.WriteLine(sortedPeople.Count);
Console.WriteLine(people.Count);