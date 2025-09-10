using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aprendizado_Lógica_de_Programação
{
     class Aula06_Conversão_Tipos
    {
        static void Main()
        {
            // Conversão de tipos em C# 

            // Conversão implícita (automática)

            int varInt = 10;
            double varDouble = varInt;
            Console.WriteLine(varDouble); // Saída: 10

            int numeroInt = 21456789;
            long numeroLong = numeroInt; // Conversão implícita de int para long
            float numeroFloat = numeroInt; // Conversão implícita de int para float
            double numeroDouble2 = numeroInt; // Conversão implícita de int para double 
            decimal numeroDecimal = numeroInt; // Conversão implícita de int para decimal
            Console.WriteLine(numeroDecimal); // Saída: 21456789


            // Conversão explícita (cast)

            double varDouble2 = 9.78;
            int varInt2 = (int)varDouble2; // Conversão explícita de double para int

            // Conversão metodo To String

            int varInt3 = 103;
            double varDouble3 = 9.78;
            decimal varDecimal = 19.95m;

            string s1 = varInt3.ToString();
            string s2 = varDouble3.ToString();
            string s3 = varDecimal.ToString();

            // Classe convert

            string str1 = "123";
            int num1 = Convert.ToInt32(str1);
            Console.WriteLine(num1); // Saída: 123

            string str2 = "123.45";
            double num2 = Convert.ToDouble(str2);
            Console.WriteLine(num2); // Saída: 123.45




        }
    }
}
