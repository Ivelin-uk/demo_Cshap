namespace loop_03
{
    public class App
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("start1");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("end");
            //Print();
        }

        public static void Print()
        {
            Console.WriteLine("Hello World!");
        }
    }
}