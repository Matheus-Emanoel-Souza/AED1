
//pelo menos 2 construtores.
//os métodos get e set.
//Bissexto() que retorna verdadeiro se o ano atual for bissexto, e retorna falso caso contrário. 
//Incrementa(int dias) da classe Data. Esse método adiciona à data atual o número de dias informado como parâmetro. 
//Diferença que retorna o número de dias entre duas datas (a atual e uma outra informada como parâmetro).

using System.Security.Cryptography.X509Certificates;
using System;

public class Data()
{
    int dia { get; set; }
    int mes { get; set; }
    int ano { get; set; }
    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
}

class Program()
{
    static void Main() {
        string nomedomes;
        string datastring = "13/11/2002";
        string[] partes = datastring.Split('/');

        int dia = int.Parse(partes[0]);
        int mes = int.Parse(partes[1]);
        int ano = int.Parse(partes[2]);
        Data data = new Data(); 

        nomedomes = NomeMes(mes);

        static string NomeMes(int num)
        {
            string MesAtual;

            Dictionary<int, (string,int)> tabelinha = new Dictionary<int, (string,int)>()
            {
                {1, ("janeiro", 31)},
                {2, ("Fevereiro", 28)},
                {3, ("Março", 31)},
                {4, ("Abril", 30)},
                {5, ("Maio", 31)},
                {6, ("junho", 30)},
                {7, ("julho", 31)},
                {8, ("Agosto", 31)},
                {9, ("Setembro", 30)},
                {10, ("Outubro", 31)},
                {11, ("Novembro", 30)},
                {12, ("Dezembro", 31)},
            };

            if (tabelinha.ContainsKey(num))
            {
                MesAtual = tabelinha[num];
            }

            else
            {
                MesAtual = "Mes não encontrado";
            }

            return MesAtual;
}
 }
 }

