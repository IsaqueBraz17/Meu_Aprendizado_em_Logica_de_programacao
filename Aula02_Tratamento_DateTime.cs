using System;

class Program
{
    static void Main()
    {
        // Tratamentos de Data e Hora

        // Obtendo a data e hora atual
        DateTime dataAtual = DateTime.Now;
        Console.WriteLine($"Data e Hora Atual: {dataAtual}");

        // Obtendo apenas a data atual
        DateTime dataEspecifica = new DateTime(2023, 12, 25);
        Console.WriteLine($"Data Específica: {dataEspecifica}");

        // Obtendo apenas a hora atual  
        DateTime dataHorasAtual = new DateTime(2023, 12, 25);
        Console.WriteLine($"Data Específica: {dataHorasAtual}");

        //  Extraindo informações específicas
        DateTime hoje = DateTime.Now;
        Console.WriteLine($"Ano:, {hoje.Year}");
        Console.WriteLine($"Mês:, {hoje.Month}");
        Console.WriteLine($"Dia:, {hoje.Day}");
        Console.WriteLine($"Hora:, {hoje.Hour}");
        Console.WriteLine($"Minuto:, {hoje.Minute}");
        Console.WriteLine($"Segundo:, {hoje.Second}");
        Console.WriteLine($"Milesegundos:, {hoje.Millisecond}");

        // Adicionando e subtraindo tempo
        Console.WriteLine($"Adicionando dias: {hoje.AddDays(30)}");
        Console.WriteLine($"Adicionando meses: {hoje.AddMonths(5)}");
        Console.WriteLine($"Adicionando anos: {hoje.AddYears(2)}");
        Console.WriteLine($"Adicionando horas: {hoje.AddHours(3)}");

        Console.WriteLine($"Subtraindo dias: {hoje.AddDays(-15)}");
        Console.WriteLine($"Subtraindo horas: {hoje.AddHours(-3)}");
        Console.WriteLine($"Subtraindo minutos: {hoje.AddMinutes(-45)}");
        Console.WriteLine($"Subtraindo segundos: {hoje.AddSeconds(-30)}");
        Console.WriteLine($"Subtraindo milissegundos: {hoje.AddMilliseconds(-500)}");

        // Data no formato longo e curto
        Console.WriteLine($"Data Longa: {hoje.ToLongDateString()}");
        Console.WriteLine($"Data Curta: {hoje.ToShortDateString()}");
    }
}
