using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            float n1,n2,resultado;
            Console.WriteLine("Programa para dividir dois números");
            Console.WriteLine("Digite o dividendo: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o divisor: ");
            n2 = float.Parse(Console.ReadLine());
            if(n2 != 0)
            {
                resultado = n1 / n2;
                Console.WriteLine("O resultado da divisão é: " + resultado);
            }
            else
            {
                Console.WriteLine("Divisão Impossível, o divisor é igual a 0");
            }
            Console.WriteLine("O programa foi executado, aperte enter para sair");
            Console.ReadLine();
        }
    }
}
