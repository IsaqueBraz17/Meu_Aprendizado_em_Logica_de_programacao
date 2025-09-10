using System;

class Aula05_Sequencias_Escapes
{
    static void Main()
    {
        // Sequências de escape em C#

        //\a Sianl sonoro (alerta) 
        Console.WriteLine("Alerta!\a");

        //\b Backspace
        Console.WriteLine("12345\b");

        //\f Form feed (avança para a próxima página)
        Console.WriteLine("Linha1\fLinha2");

        //\n Nova linha
        Console.WriteLine("Linha1\nLinha2");

        //\r Retorno de carro (carriage return)
        Console.WriteLine("12345\rABCDE");

        //\t Tabulação horizontal
        Console.WriteLine("Coluna1\tColuna2\tColuna3");

        //\v Tabulação vertical
        Console.WriteLine("Linha1\vLinha2\vLinha3");

        //\\ Barra invertida
        Console.WriteLine("C:\\Pasta\\Arquivo.txt");

        // \? IntErrogação
        Console.WriteLine("Isso é uma interrogação: \?");

        //\" Aspas duplas
        Console.WriteLine("Ele disse: \"Olá!\"");

        //\' Aspas simples
        Console.WriteLine("Isso é uma aspa simples: \' ");






    }
}