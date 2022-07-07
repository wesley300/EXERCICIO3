using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string escolha;
            double lado, lado2, area;

            Console.WriteLine("Escolha uma figura (triangulo, pentagono, hexagono)");
            escolha = Console.ReadLine();

            switch (escolha)
            {
                case "triangulo":
                    Console.WriteLine("Escreva a medida da base: ");
                    lado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escreva a medida da altura: ");
                    lado2 = Convert.ToDouble(Console.ReadLine());
                    area = (lado * lado2) / 2;
                    Console.WriteLine("\nÁrea do triangulo: " + area);
                    break;
                case "pentagono":
                    Console.WriteLine("Escreva a medida do lado: ");
                    lado = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Escreva a medida da apótema: ");
                    lado2 = Convert.ToDouble(Console.ReadLine());
                    area = 5 * lado * lado2;
                    Console.WriteLine("\nÁrea do pentagono: " + area);
                    break;
                case "hexagono":
                    Console.WriteLine("Escreva a medida do lado: ");
                    lado = Convert.ToDouble(Console.ReadLine());
                    area = 3 * (lado * lado) * Math.Pow(3, 0.5);
                    Console.WriteLine("\nÁrea do hexagono: " + area);
                    break;
            }

            Console.ReadKey();
        }
    }
}
