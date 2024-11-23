string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string town = Console.ReadLine();

string r = "You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town +".";
string r2 = $"You are {firstName} {lastName}, a {age}-years old person from {town}.";

Console.WriteLine(r);
Console.WriteLine(r2);
Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", firstName, lastName, age, town);