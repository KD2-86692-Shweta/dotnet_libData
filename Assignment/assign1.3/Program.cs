using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Enter two numbers");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());


            do
            {
                {
                    Console.WriteLine("1.add\n 2.sub\n 3.mul\n 4.div");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    int result;

                    switch (choice)
                    {
                        case 1:
                            result = x + y;
                            Console.WriteLine(result);
                            break;
                        case 2:
                            result = x - y;
                            Console.WriteLine(result);
                            break;
                        case 3:
                            result = x * y;
                            Console.WriteLine(result);
                            break;
                        case 4:
                            result = x / y;
                            Console.WriteLine(result);
                            break;
                        default:
                            break;


                    }
                }
            } while (true);




        }
    }
}