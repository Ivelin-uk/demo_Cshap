/*
 Да се напише програма, която намира всички числа в
 интервала от 1 до 1000, които завършват на 7:
*/

namespace loop_05
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            for (int number = 7; number <= 1000; number+=10)
            {
                Console.WriteLine(number);
            }
        }
    }
}