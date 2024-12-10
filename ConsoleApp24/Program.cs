using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class Program
    {
        
        public static double CalculateY()
        {
            
            double y = (Math.Sqrt(7) + 7) / 3 + (Math.Sqrt(11) + 11) / 3 + (Math.Sqrt(15) + 15) / 3;
            return y;
        }

        static void Main(string[] args)
        {
           
            double result = CalculateY();
            Console.WriteLine($"Значение y: {result}");
            Console.ReadKey();
        }
    }
}
