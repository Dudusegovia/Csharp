using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex00
{
    internal class Program
    { 
        static double Soma()
        {
            double a;
            double b;
            Console.WriteLine("digite um numero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite outro numero: ");
            b = Convert.ToDouble(Console.ReadLine());
            return a + b;
        }
    
        static void Main(string[] args)
        {
            Console.WriteLine(Soma());
            Console.ReadKey();
        }
    }
}
