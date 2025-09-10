using System;

class Aula04_Formatação
{
    static void Main()
    {
        int idade = 20;
        string nome = "Isaque";
        Console.WriteLine(nome);
        Console.WriteLine(idade);


        // Escreva na mesma linha 'Isaque tem 20 anos'

        // Concatenando
        Console.WriteLine(nome + " tem " + idade + " anos");

        // Interpolação
        Console.WriteLine($"{nome} tem {idade} anos");

        // Place holders
        Console.WriteLine("{0} tem {1} anos", nome, idade);

    }
}