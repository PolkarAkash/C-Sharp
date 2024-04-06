using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            if (i == 10)
            {
                Console.WriteLine("ten");
            }
            else
            {
                Console.WriteLine("not ten");
            }
            Console.ReadLine(); */

            int i = 20;
             if(i==10)
             {
                 Console.WriteLine("ten");
             }
             else if(i==20)
             {
                 Console.WriteLine("tweenty");
             }  
             else if (i==30) 
             {
                 Console.WriteLine("thirty");
             }
             else
             {
                 Console.WriteLine("not in 10,20 and 30");       
             }
             Console.ReadLine();
             

            int i = 20;
            switch (i)
            {
                case 10:
                    Console.WriteLine("ten");
                    break;
                case 20:
                    Console.WriteLine("tweenty");
                    break;
                case 30:
                    Console.WriteLine("thirty");
                    break;
                default:
                    Console.WriteLine("not in 20,30 and 40");
                    break;
            }
            Console.ReadLine();

        }
    }
}
