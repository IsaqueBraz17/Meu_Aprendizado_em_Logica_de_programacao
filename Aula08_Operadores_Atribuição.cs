using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizado_Lógica_de_Programação
{
    internal class Aula08_Operadores_Atribuição
    {
        static void Main()
        {
            // Operadores de Atribuição em C#

            int x = 10; // Operador de atribuição simples
            Console.WriteLine($"Valor inicial de x: {x}");

            x += 5; // Equivalente a x = x + 5
            Console.WriteLine($"Após x += 5, valor de x: {x}");

            x -= 3; // Equivalente a x = x - 3
            Console.WriteLine($"Após x -= 3, valor de x: {x}");

            x *= 2; // Equivalente a x = x * 2
            Console.WriteLine($"Após x *= 2, valor de x: {x}");

            x /= 4; // Equivalente a x = x / 4
            Console.WriteLine($"Após x /= 4, valor de x: {x}");

            x %= 3; // Equivalente a x = x % 3
            Console.WriteLine($"Após x %= 3, valor de x: {x}");

        }
    }
}
