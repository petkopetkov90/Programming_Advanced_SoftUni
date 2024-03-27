using Tuple;

string[] nameAndAddress = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string name = nameAndAddress[0] + " " + nameAndAddress[1];
string address = $"{string.Join(" ", nameAndAddress.Skip(2))}";

string[] nameLittersOfBeer = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

string name2 = nameLittersOfBeer[0];
int litters = int.Parse(nameLittersOfBeer[1]);

string[] integerAndDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

int numberInt = int.Parse(integerAndDouble[0]);
double numberDouble = double.Parse(integerAndDouble[1]);

Tuple.Tuple<string, string> nameAdrees = new Tuple.Tuple<string, string>(name,address);
Tuple.Tuple<string, int> nameBeer = new Tuple.Tuple<string, int>(name2, litters);
Tuple.Tuple<int, double> intDouble = new Tuple.Tuple<int, double>(numberInt, numberDouble);

Console.WriteLine($"{nameAdrees.Item1} -> {nameAdrees.Item2}");
Console.WriteLine($"{nameBeer.Item1} -> {nameBeer.Item2}");
Console.WriteLine($"{intDouble.Item1} -> {intDouble.Item2}");