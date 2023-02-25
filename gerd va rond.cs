using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication115
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("enter price");

                double price = Convert.ToDouble(Console.ReadLine());

                int gerd = Convert.ToInt32(price);

                Console.WriteLine("enter type");

                Console.WriteLine("1) rond 2) gerd");

                int type = Convert.ToInt16(Console.ReadLine());
                if (type == 1) 
                { 
                    Console.WriteLine(gerd); 
                }
                else if (type == 2)
                {
                    double a = (price - gerd);
                    if (a > 0.5) 
                    {
                        Console.WriteLine(gerd + 1); 
                    }
                    else if (a < 0.5) 
                    {
                        Console.WriteLine(gerd);
                    }
                }
                else 
                {
                    Console.WriteLine("invalid"); 
                }
                Console.ReadKey();
            }
        }   
    }
}
