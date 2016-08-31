using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(new string('-', n * 3));
                        Console.Write('*');
                        Console.Write(new string('-', i));
                        Console.Write('*');
                        Console.WriteLine(new string('-', n * 2 - 2 - i));
                    }
                    for (int i = 0; i < n / 2; i++)
                    {
                        Console.Write(new string('*', n * 3 + 1));
                        Console.Write(new string('-', n - 1));
                        Console.Write('*');
                        Console.WriteLine(new string('-', n - 1));
                    }
                    for (int i = 0; i < n / 2; i++)
                    {
                        if (i < n / 2 - 1)
                        {

                            Console.Write(new string('-', n * 3 - i));
                            Console.Write('*');
                            Console.Write(new string('-', n - 1 + i * 2));
                            Console.Write('*');
                            Console.WriteLine(new string('-', n - i - 1));
                        }
                        else if (i == n / 2 - 1)
                        {
                            Console.Write(new string('-', n * 3 - i));
                            Console.Write(new string('*', n * 2 - 1));
                            Console.WriteLine(new string('-', n - i - 1));
                        }
                    }
                }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(new string('-', n * 3));
                    Console.Write('*');
                    Console.Write(new string('-', i));
                    Console.Write('*');
                    Console.WriteLine(new string('-', n * 2 - 2 - i));
                }
                for (int i = 0; i < n / 2; i++)
                {
                    Console.Write(new string('*', n * 3 + 1));
                    Console.Write(new string('-', n - 1));
                    Console.Write('*');
                    Console.WriteLine(new string('-', n - 1));
                }
                for (int i = 0; i < n / 2; i++)
                {
                    if (i < n / 2 - 1)
                    {

                        Console.Write(new string('-', n * 3 - i));
                        Console.Write('*');
                        Console.Write(new string('-', n - 1 + i * 2));
                        Console.Write('*');
                        Console.WriteLine(new string('-', n - i - 1));
                    }
                    else if (i == n / 2 - 1)
                    {
                        Console.Write(new string('-', n * 3 - i));
                        Console.Write(new string('*', n * 2 - 2));
                        Console.WriteLine(new string('-', n - i - 1));
                    }
                }
            }                        
        }
    }
}
