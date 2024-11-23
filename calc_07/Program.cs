//int inches = 39.3700787; errror
//string input1 = Console.ReadLine(); // въвеждаме текст
//string input2 = Console.ReadLine(); // въвеждаме текст
//string input3 = input1 + input2;
//Console.WriteLine(input3);

int input1 = int.Parse(Console.ReadLine()); 
//Важно: висчко въведено от темината се приема за текст
//int.Parse() приема това което се въвесли в терминала  и го прави на число
int input2 = int.Parse(Console.ReadLine()); // въвеждаме текст
int input3 = input1 + input2;
Console.WriteLine(input3);