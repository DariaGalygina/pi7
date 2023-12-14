using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi
{
    public class Program
    {
        public static bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (IsPrime(number))
            {
                Console.WriteLine($"{number} - простое число");
            }
            else
            {
                Console.WriteLine($"{number} - не является простым числом");
            }
        }
    }
}
