using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Estrutura_Condicional_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para ler um número inteiro e dizer se este nº é par ou ímpar");
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0 && num >= 0) 
            {
                Console.WriteLine("Número par");
            }
            else if(num < 0 && num % 2 == 0)
            {
                Console.WriteLine("Negativo e par");
            }
            else if (num < 0 && num % 2 != 0)
            {
                Console.WriteLine("Negativo e ímpar");
            }

            else
            {
                Console.WriteLine("Número ímpar!");
            }
        }
    }
}
