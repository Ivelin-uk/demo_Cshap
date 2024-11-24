using System;
namespace loops_16
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            
            for (int i = 0; i < n; i++)
            {
                int craft_dessert = int.Parse(Console.ReadLine());
                if (craft_dessert >= 100 && craft_dessert < 200)
                {
                    group1 += 1;
                }
                
                if (craft_dessert >= 200 && craft_dessert < 300)
                {
                    group2 += 1;
                }
                
                if (craft_dessert >= 300 && craft_dessert < 400)
                {
                    group3 += 1;
                }
            }

            Console.WriteLine($"Group 1: {group1} craft-desserts.");
            Console.WriteLine($"Group 2: {group2} craft-desserts.");
            Console.WriteLine($"Group 3: {group3} craft-desserts.");
        }
    }
}