using System;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public bool GeneroFeminino { get; set; }
    public double altura { get; set; }

    public Pessoa(string Nome, int Idade, bool GeneroFeminino, double altura)
    {
        this.Nome = Nome;
        this.Idade = Idade;
        this.altura = altura;
        this.GeneroFeminino = GeneroFeminino;
    }
    public void ExibirDetalhesPessoa()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Idade:{Idade}");
        Console.WriteLine($"Gênero:{(GeneroFeminino ? "Feminino":"Masculino")}");
        Console.WriteLine($"altura:{altura}");
    }
}
public class Funcionario : Pessoa
{
    public string empresa { get; set; }
    public string cargo { get; set; }
    public double salario { get; set; }
    public Funcionario(string Nome,string empresa, string cargo, double salario, double altura,int Idade, bool GeneroFeminino):base(Nome, Idade,GeneroFeminino,altura)
    {
        this.empresa = empresa;
        this.cargo = cargo;
        this.salario = salario;
    }
    public void ExibirdetalhesFuncionario()
    {
        Console.WriteLine($"Empresa:{empresa}");
        Console.WriteLine($"Cargo:{cargo}");
        Console.WriteLine($"Salário:R${salario}");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa("José", 30, false, 1.75);
        pessoa.ExibirDetalhesPessoa();

        Console.WriteLine();

        Funcionario funcionario = new Funcionario("lorisangela", "Acellor", "Gerênte", 1000, 1.60, 75, true);
        funcionario.ExibirdetalhesFuncionario();
    }
}