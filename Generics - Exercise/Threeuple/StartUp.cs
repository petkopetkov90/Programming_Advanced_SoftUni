
using Threeuple;

string[] nameAndAddressTown = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string name = nameAndAddressTown[0] + " " + nameAndAddressTown[1];
string address = nameAndAddressTown[2];
string town = $"{string.Join(" ", nameAndAddressTown.Skip(3))}";

string[] nameLittersOfBeerDrunk = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string name2 = nameLittersOfBeerDrunk[0];
int litters = int.Parse(nameLittersOfBeerDrunk[1]);
bool drunk = "drunk" == nameLittersOfBeerDrunk[2];

string[] nameBankDetails = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string client = nameBankDetails[0];
double number = double.Parse(nameBankDetails[1]);
string bank = nameBankDetails[2];

Threeuple<string, string, string> nameAdrees = new Threeuple<string, string, string>(name, address, town);
Threeuple<string, int, bool> nameBeer = new Threeuple<string, int, bool>(name2, litters, drunk);
Threeuple<string, double, string> nameBank = new Threeuple<string, double, string>(client, number, bank);

Console.WriteLine($"{nameAdrees.Item1} -> {nameAdrees.Item2} -> {nameAdrees.Item3}");
Console.WriteLine($"{nameBeer.Item1} -> {nameBeer.Item2} -> {nameBeer.Item3}");
Console.WriteLine($"{nameBank.Item1} -> {nameBank.Item2} -> {nameBank.Item3}");