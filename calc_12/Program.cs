double score = 1024.32432;

Console.WriteLine("Score: {0}", score);
Console.WriteLine("Score: " + score);
Console.WriteLine($"Score: {score:F2}");

string name = "Ivan";
Console.WriteLine($"My name is {name} and my is {score:F2}");
Console.WriteLine("My name is {0} and my is {1}", name, score); // !!!!
Console.WriteLine("My name is " + name + " and my is " + score);