using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02
{
    internal class Program
    {
        static double distancia;
        static double litros;
        static double consumo;
        static void Extrai()
        {
            Console.WriteLine("Escreva a distância percorrida: ");
            distancia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escreva o consumo em litros: "); 
            litros = Convert.ToDouble(Console.ReadLine());
        }

        static void CalculaConsumo()
        {
            consumo = litros / distancia;
        }

        static void Saida()
        {
            Console.WriteLine("Km percorridos: " + distancia + "km");
            Console.WriteLine("Quantidade de litros: " + litros + "L");
            Console.WriteLine("O consumo MÉDIO foi de: " + consumo + "km/L");

        }
        static void Main(string[] args)
        {
            Extrai();
            CalculaConsumo();
            Saida();
        }
    }
}
