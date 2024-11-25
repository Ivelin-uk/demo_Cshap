using System;
namespace loops_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int n1 = 1; n1 <= 9; n1++)
            {
                for (int n2 = 1; n2 <= 9; n2++)
                {
                    for (int n3 = 1; n3 <= 9; n3++)
                    {
                        for (int n4 = 1; n4 <= 9; n4++)
                        {
                            for (int n5 = 1; n5 <= 9; n5++)
                            {
                                //сбора от първите три цифри е равен на N
                                int sum = n1 + n2 + n3;
                                if (sum == number && n4 % 2 == 0 && n5 == 1)
                                {
                                    Console.Write($"{n1}{n2}{n3}{n4}{n5} ");
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
            
            Console.WriteLine($"Count of winner numbers: {counter}");
        }
    }
}