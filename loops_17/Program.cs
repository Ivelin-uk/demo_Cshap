using System;
namespace loops_17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counterTile = 0;
            int counterTools = 0;
            int counterPaint = 0;
            
            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                if (currentProduct == "tile")
                {
                    counterTile += 1;
                }
                
                if (currentProduct == "tools")
                {
                    counterTools += 1;
                }
                
                if (currentProduct == "paint")
                {
                    counterPaint += 1;
                }
            }

            Console.WriteLine($"Tiles: {counterTile}");
            Console.WriteLine($"Tools: {counterTools}");
            Console.WriteLine($"Paint: {counterPaint}");
        }
    }
}