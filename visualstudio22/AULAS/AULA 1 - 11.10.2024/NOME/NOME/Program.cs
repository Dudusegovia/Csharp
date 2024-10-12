using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOME
{
    internal class Program
    {
        static string[] Nome = new string[10];

        static void EntradaNomes()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("digite um nome: ", i);
                Nome[i] = Console.ReadLine();
            }
            Console.WriteLine("fim dados");
            Console.ReadKey();
        }
        static void SaidaNomes()
        {
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine("Digitar um Nome:{0} : {1} ", i, Nome[i]);


            }
            Console.ReadKey();


        }
        static void Main(string[] args)
        {
            EntradaNomes();
            SaidaNomes();
        }
    }
}
