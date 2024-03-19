using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe as horas (formato HH:mm):");
        DateTime hora;

        // Laço para garantir que o usuário forneça uma entrada válida
        while (!DateTime.TryParseExact(Console.ReadLine(), "HH:mm", null, System.Globalization.DateTimeStyles.None, out hora))
        {
            Console.WriteLine("Formato de hora inválido. Por favor, insira no formato HH:mm.");
        }

        Console.WriteLine($"Você inseriu: {hora.ToString("HH:mm")}");
    }
}
