using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, media;
            Console.WriteLine("Programa para calcular média");
            Console.WriteLine("Digite a nota A: ");
            notaA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota B: ");
            notaB = Convert.ToDouble(Console.ReadLine());
            media = ((notaA * 3.5) + (notaB * 7.5)) / (3.5+7.5);
            Console.WriteLine("A média é: " + media);
            Console.WriteLine("O programa foi executado, aperte enter para sair");
            Console.ReadLine();
        }
    }
}
