﻿namespace loop_04
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            //Console.WriteLine(57 % 10 == 7);
            //Console.WriteLine(6 == 5);

            for (int number = 1; number <= 1000; number++)
            {
                if (number % 10 == 7)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}