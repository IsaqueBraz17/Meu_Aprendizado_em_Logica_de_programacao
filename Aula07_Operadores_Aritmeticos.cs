using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizado_Lógica_de_Programação
{
    internal class Aula07_Operadores_Aritmeticos
    {
        static void Main()
        {
            Console.Write("Digite um número: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro número: ");
            int y = Convert.ToInt32(Console.ReadLine());

            // Operador Adição (+)
            int soma = x + y;
            Console.WriteLine($"A soma de {x} + {y} = {soma}");

            // Operador Subtração (-)
            int subtracao = x - y;
            Console.WriteLine($"A subtração de {x} - {y} = {subtracao}");

            // Operador Multiplicação (*)
            int multiplicacao = x * y;
            Console.WriteLine($"A multiplicação de {x} * {y} = {multiplicacao}");

            // Operador Divisão (/)
            if (y != 0)
            {
                double divisao = (double)x / y;
                Console.WriteLine($"A divisão de {x} / {y} = {divisao}");
            }
            else
            {
                Console.WriteLine("Divisão por zero não é permitida.");
            }

            // Classe Math

            // Raiz quadrada
            Console.WriteLine($"Valor Raiz quadrada de x: {Math.Sqrt(x)}");
        }
    }
}
