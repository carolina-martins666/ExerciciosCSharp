using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2,soma;
            Console.WriteLine("Programa para calcular a soma de números inteiros");
            Console.WriteLine("Digite um número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            n2 = int.Parse(Console.ReadLine());
            soma = n1 + n2;
            Console.WriteLine("A soma dos dois números é: " + soma);
            Console.WriteLine("O programa foi executado, para sair aperte enter");
            Console.ReadLine();
        }
    }
}
