namespace loop_08
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char n = '!';
            int n2 = 66;
            char n3 = (char)n2;
            //1001
            Console.WriteLine((int)n);
            Console.WriteLine(n3);
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i + " ");
            }

            Console.WriteLine();
            
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}