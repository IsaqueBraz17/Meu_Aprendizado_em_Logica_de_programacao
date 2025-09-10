using System;

class Aula01_Tipos_de_Dados
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Variaveis e Tipos de dados");

        Console.WriteLine("Tipos de dados inteiros:");

        sbyte tipoSByte = 100; // 8 bits, -128 to 127
        byte tipoByte = 200; // 8 bits, 0 to 255
        short tipoShort = 30000; // 16 bits, -32,768 to 32,767
        ushort tipoUShort = 60000; // 16 bits, 0 to 65,535
        int tipoInt = 2000000000; // 32 bits, -2,147,483,648 to 2,147,483,647
        uint tipoUInt = 4000000000; // 32 bits, 0 to 4,294,967,295
        long tipoLong = 9000000000000000000; // 64 bits, -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
        ulong tipoULong = 18000000000000000000; // 64 bits, 0 to 18,446,744,073,709,551,615
        //nint tipoNInt = -5000000000;   // inteiro com sinal, 32 ou 64 bits
        //nuint tipoNUInt = 5000000000;  // inteiro sem sinal, 32 ou 64 bits

        Console.WriteLine();
        Console.WriteLine("Tipos de dados de ponto flutuante:");

        float tipoFloat = 3.14f; // 32 bits, ~6-9 digits precision
        double tipoDouble = 3.14159265358979; // 64 bits, ~15-17 digits precision
        decimal tipoDecimal = 3.1415926535897932384626433832m; // 128 bits, ~28-29 digits precision

        Console.WriteLine();
        Console.WriteLine("Tipos de dados não numericos:");

        bool tipoBool = true; // true or false
        char tipoChar = 'A'; // 16 bits, single character

        Console.WriteLine();
        Console.WriteLine("Tipos de dados de referencia:");

        string tipoString = "Hello, World!"; // sequence of characters
        object tipoObject = new object(); // base type for all types
        dynamic tipoDynamic = "I can change type"; // resolved at runtime

        // Verificar o tipo de uma variável
        Console.WriteLine($"O tipo da variável é: {tipoBool.GetType().Name}");
    }
}