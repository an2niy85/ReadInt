using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;

            number = ReadInt();
            Console.WriteLine(number);
            Console.ReadKey();
        }

        static int ReadInt()
        {
            int number;
            bool True;

            do
            {
                Console.Write("Введите число: ");
                True = int.TryParse(Console.ReadLine(), out number);

            } while (!True);
            return number;
        }
    }
}
