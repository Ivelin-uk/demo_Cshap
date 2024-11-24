using System;
namespace loops_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1 2 3 .... 99
            //0000 0001 0002 9999
            int number = int.Parse(Console.ReadLine());
            
            //0144
            for (int n1 = 0; n1 <= 9; n1++)
            {
                for (int n2 = 0; n2 <= 9; n2++)
                {
                    for (int n3 = 0; n3 <= 9; n3++)
                    {
                        for (int n4 = 0; n4 <= 9; n4++)
                        {
                            if ((n1 + n4 == number) && (n2 % 2 == 1) && (n3 == 7 || n3 == 4))
                            {
                                Console.WriteLine($"{n1}{n2}{n3}{n4}");
                            }
                        }
                    }
                }
            }
        }
    }
}