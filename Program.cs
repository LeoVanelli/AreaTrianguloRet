using System;

namespace AreaTrianguloRet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objetivo: Calcule a área de um triângulo retângulo, dados base (b) e altura (h). A área é dada pela metade do produto da base pela altura.

            Console.Write("Digite o valor da base: ");
            double b = double.Parse(Console.ReadLine()); 

            Console.Write("Digite o valor da altura: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine($"Base: {b}\nAltura: {h}\nÁrea do triângulo retângulo: {(b*h)/2}");
        }
    }
}
