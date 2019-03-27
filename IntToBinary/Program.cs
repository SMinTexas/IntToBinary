using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Integer_to_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            prog pg = new prog();
            Console.WriteLine("Enter a number : ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary equivalent of num {0} is ", num);
            pg.binaryConversion(num);
            Console.Read();
        }
    }
    public class prog
    {
        public int binaryConversion(int num)
        {
            int bin;
            if (num != 0)
            {
                bin = (num % 2) + 10 * binaryConversion(num / 2);
                Console.Write(bin);
                return 0;
            }
            else
            {
                return 0;
            }
        }

    }
}
