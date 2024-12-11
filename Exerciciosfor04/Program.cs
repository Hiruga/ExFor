using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerciciosfor04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Quadrado de Asteríscos 5x5 

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();                
            }
            */

            /* Números pares 2 a 20 

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }                
            }*/

            /* Números primos zz
            int p = 0;

            Console.WriteLine("Detector de números primos");
            Console.Write("Envie seu número primo: ");
            p = int.Parse(Console.ReadLine());
            if (p != 1)
            {
                for (int i = 1; i <= p; i++)
                {
                    Console.WriteLine("Testando o valor: " + i);
                    
                    if (i == 1) // Esse teste com o 1 é desnecessário, mantido somente pra esclarecer a lógica//
                    {
                        Console.WriteLine("Número divisível por 1");
                        Console.WriteLine("");
                    }
                    if (i == p)
                    {
                        Console.WriteLine("Número divisível por ele mesmo");
                        Console.WriteLine("Este número definitivamente é primo!");
                        Console.WriteLine("");
                        break;
                    }
                    if (p % i == 0 && i != 1)
                    {
                        Console.WriteLine("Número divisível por " + i);
                        Console.WriteLine("Este número não é primo! fake fan");
                        Console.WriteLine("");
                        break;
                    }
                }
            }
            else { Console.WriteLine("1 não é um número primo!"); }*/

            /* Fatorial! 
            int f = 0; 
            Console.WriteLine("Calculador de Fatorial!");
            Console.Write("Envie o número para ser calculado: ");
            f = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = f; i > 0; i--)
            {
                f = f * i;
                Console.WriteLine(f);
            }*/

            /* Contagem regressiva 

            Console.WriteLine("Contagem regressiva...");

            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }*/

            Console.ReadKey();
        }
    }
}
