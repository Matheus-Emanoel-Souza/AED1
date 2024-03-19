using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe a hora (0-23):");
        int hora;

        // Laço para garantir que o usuário forneça uma entrada válida
        while (!int.TryParse(Console.ReadLine(), out hora) || hora < 0 || hora > 23)
        {
            Console.WriteLine("Hora inválida. Por favor, insira um número inteiro de 0 a 23.");
        }

        string saudacao = ObterSaudacao(hora);
        Console.WriteLine(saudacao);
    }

    static string ObterSaudacao(int hora)
    {
        if (hora >= 6 && hora < 12)
        {
            return "Bom dia!";
        }
        else if (hora >= 12 && hora < 18)
        {
            return "Boa tarde!";
        }
        else
        {
            return "Boa noite!";
        }
    }
}
