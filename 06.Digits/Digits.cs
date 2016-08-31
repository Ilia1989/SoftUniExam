using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Digits
{
    class Digits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 100 || n > 999)
            {
                return;
            }

            int first = (n - n % 100) / 100;

            int second = (n % 100 - n % 10) / 10;

            int third = n % 10;

            int row = first + second;
            int col = first + third;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (n % 5 == 0)
                    {
                        n -= first;
                        Console.Write("{0} ", n);
                    }
                    else if (n % 3 == 0)
                    {
                        n -= second;
                        Console.Write("{0} ", n);
                    }
                    else
                    {
                        n += third;
                        Console.Write("{0} ", n);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
