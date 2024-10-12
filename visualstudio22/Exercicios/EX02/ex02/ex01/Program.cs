using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
    internal class Program
    {
        static double a;
        static double b;
        static void ExtraiNum()
        {
            Console.WriteLine("digite um numero: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("digite outro numero: ");
            b = Convert.ToDouble(Console.ReadLine());
        }
        static double Soma()
        {
            Console.WriteLine("SOMA: ");
            return a + b;
        }
        static double Subtracao()
        {
            Console.WriteLine("SUBTRAÇÃO: ");
            return a - b;
        }
        static double Divisao()
        {
            Console.WriteLine("DIVISÃO: ");
            return a / b;
        }
        static double Multiplicacao()
        {
            Console.WriteLine("PRODUTO: ");
            return a * b;
        }

        static void Main(string[] args)
        {
            ExtraiNum();
            Console.WriteLine(Soma());
            Console.WriteLine(Subtracao());
            Console.WriteLine(Divisao());
            Console.WriteLine(Multiplicacao());

            Console.ReadKey();
        }
    }
}
