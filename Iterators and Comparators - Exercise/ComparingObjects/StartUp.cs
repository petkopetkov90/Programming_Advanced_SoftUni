
using ComparingObjects;

List<Person> peoples = new List<Person>();

string input;
while ((input = Console.ReadLine()) != "END")
{
    string[] personDetails = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string name = personDetails[0];
    int age = int.Parse(personDetails[1]);
    string town = personDetails[2];

    Person person = new Person(name, age, town);
    peoples.Add(person);
}

int index = int.Parse(Console.ReadLine()) - 1;
Person personToCompare = peoples[index];

int equals = 0;
int notEqual = 0;

foreach (Person person in peoples)
{
    if (personToCompare.CompareTo(person) == 0)
    {
        equals++;
    }
    else
    {
        notEqual++;
    }
}

if (equals == 1)
{
    Console.WriteLine("No matches");
}
else
{
    Console.WriteLine($"{equals} {notEqual} {peoples.Count}");
}