using System;
using System.IO;
using System.Linq;
using System.Text;

class Program
{
    class Criptografia
    {
        private readonly string chave;

        public Criptografia(string chave)
        {
            this.chave = chave;
        }

        public void Criptografar(string texto, string nomeArquivo)
        {
            string textoCriptografado = AplicarChave(texto);
            File.WriteAllText(nomeArquivo, textoCriptografado);
            Console.WriteLine("Texto criptografado gravado em arquivo com sucesso!");
        }

        public void Descriptografar(string nomeArquivo)
        {
            string textoCriptografado = File.ReadAllText(nomeArquivo);
            string textoDescriptografado = AplicarChaveInversa(textoCriptografado);
            Console.WriteLine("Texto descriptografado: " + textoDescriptografado);
        }

        public void ExibirTexto(string nomeArquivo)
        {
            string texto = File.ReadAllText(nomeArquivo);
            Console.WriteLine("Texto no arquivo: " + texto);
        }

        private string AplicarChave(string texto)
        {
            StringBuilder textoCriptografado = new StringBuilder();
            foreach (char caractere in texto)
            {
                if (chave.Contains(caractere))
                {
                    int indice = chave.IndexOf(caractere);
                    textoCriptografado.Append(indice.ToString());
                }
                else
                {
                    textoCriptografado.Append(caractere);
                }
            }
            return textoCriptografado.ToString();
        }

        private string AplicarChaveInversa(string textoCriptografado)
        {
            StringBuilder textoDescriptografado = new StringBuilder();
            foreach (char caractere in textoCriptografado)
            {
                if (char.IsDigit(caractere))
                {
                    int indice = int.Parse(caractere.ToString());
                    textoDescriptografado.Append(chave[indice]);
                }
                else
                {
                    textoDescriptografado.Append(caractere);
                }
            }
            return textoDescriptografado.ToString();
        }
    }
        static void Main()
    {
        Console.WriteLine("Escolha o exercício que deseja acessar:");
        Console.WriteLine("1. Exercício 1");
        Console.WriteLine("2. Exercício 2");
        Console.WriteLine("3. Exercício 3");
        Console.WriteLine("4. Exercício 4");
        Console.WriteLine("5. Exercício 5");
        Console.WriteLine("6. Exercício 6");
        Console.WriteLine("7. Exercício 7");
        Console.WriteLine("8. Exercício 8");
        Console.Write("Opção: ");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Exercicio1();
                break;
            case 2:
                Exercicio2();
                break;
            case 3:
                Exercicio3();
                break;
            case 4:
                Exercicio4();
                break;
            case 5:
                Exercicio5();
                break;
            case 6:
                Exercicio6();
                break;
            case 7:
                Exercicio7();
                break;
            case 8:
                Exercicio8();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
    static void Exercicio1()
    {
        using (StreamWriter writer = new StreamWriter("multiplos_de_7.txt"))
        {
            while (true)
            {
                Console.Write("Digite um número (negativo para parar): ");
                int numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                    break;

                if (numero % 7 == 0)
                    writer.WriteLine(numero);
            }
        }
        Console.WriteLine("Números múltiplos de 7 gravados em arquivo com sucesso!");
    }
    static void Exercicio2()
    {
        int[] numeros = new int[3];
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Digite o " + (i + 1) + "º número: ");
            numeros[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(numeros);
        File.WriteAllLines("numeros_ordenados.txt", numeros.Select(n => n.ToString()));
        Console.WriteLine("Números ordenados gravados em arquivo com sucesso!");
    }
    static void Exercicio3()
    {
        int[] numeros = File.ReadAllLines("numeros_originais.txt").Select(int.Parse).ToArray();
        Array.Sort(numeros);
        File.WriteAllLines("numeros_ordenados.txt", numeros.Select(n => n.ToString()));
        Console.WriteLine("Números ordenados gravados em arquivo com sucesso!");
    }
    static void Exercicio4()
    {
        string[] dados = File.ReadAllLines("dadosOriginais.txt");
        using (StreamWriter numPares = new StreamWriter("numPares.txt"))
        using (StreamWriter numImpares = new StreamWriter("numImpares.txt"))
        using (StreamWriter numPrimos = new StreamWriter("numPrimos.txt"))
        {
            foreach (string dado in dados)
            {
                int numero = int.Parse(dado);
                if (numero % 2 == 0)
                    numPares.WriteLine(numero);
                else
                    numImpares.WriteLine(numero);
                if (EhPrimo(numero))
                    numPrimos.WriteLine(numero);
            }
        }
        Console.WriteLine("Números separados por tipo gravados em arquivos com sucesso!");
    }
    static bool EhPrimo(int numero)
    {
        if (numero <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }
        return true;
    }
    static void Exercicio5()
    {
        string[] palavras = File.ReadAllLines("palavras.txt");
        string maiorPalavra = palavras.OrderByDescending(p => p.Length).First();
        string menorPalavra = palavras.OrderBy(p => p.Length).First();
        Console.WriteLine("Maior palavra: " + maiorPalavra);
        Console.WriteLine("Menor palavra: " + menorPalavra);
    }
    static void Exercicio6()
    {
        Criptografia cripto = new Criptografia("ATEVM#");
        cripto.Criptografar("PROGRAMAR", "textoCriptografado.txt");
        cripto.Descriptografar("textoCriptografado.txt");
    
    } 
    static void Exercicio7()
    {
        string[] palavras = File.ReadAllLines("palavras.txt");

        string maiorPalavra = palavras.OrderByDescending(p => p.Length).First();
        string menorPalavra = palavras.OrderBy(p => p.Length).First();

        Console.WriteLine("Maior palavra: " + maiorPalavra);
        Console.WriteLine("Menor palavra: " + menorPalavra);
    }
    static void Exercicio8()
    {
        string[] palavras = File.ReadAllLines("palavras.txt");
        Random rnd = new Random();
        string palavraEscolhida = palavras[rnd.Next(palavras.Length)].ToUpper();
        char[] letrasCorretas = new char[palavraEscolhida.Length];
        for (int i = 0; i < letrasCorretas.Length; i++)
        {
            letrasCorretas[i] = '_';
        }
        int tentativasRestantes = 6;
        bool palavraCompleta = false;

        while (tentativasRestantes > 0 && !palavraCompleta)
        {
            Console.WriteLine("Palavra: " + string.Join(" ", letrasCorretas));
            Console.WriteLine("Tentativas restantes: " + tentativasRestantes);
            Console.Write("Digite uma letra: ");
            char letra = Console.ReadLine().ToUpper()[0];
            bool letraCorreta = false;

            for (int i = 0; i < palavraEscolhida.Length; i++)
            {
                if (palavraEscolhida[i] == letra)
                {
                    letrasCorretas[i] = letra;
                    letraCorreta = true;
                }
            }

            if (!letraCorreta)
            {
                tentativasRestantes--;
            }

            if (string.Join("", letrasCorretas) == palavraEscolhida)
            {
                palavraCompleta = true;
            }
        }
        if (palavraCompleta)
        {
            Console.WriteLine("Parabéns! Você acertou a palavra: " + palavraEscolhida);
        }
        else
        {
            Console.WriteLine("Você perdeu! A palavra correta era: " + palavraEscolhida);
        }
    }
}
