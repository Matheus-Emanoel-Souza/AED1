using System;
public class Classe
{
    public string nomeclasse { get; set; }
    public Classe(string nomeclasse)
    {
        this.nomeclasse = nomeclasse;
    }
}
class Animal
{
    public string Nome { get; set; }
    public string Raça { get; set; }
    public Classe ClasseAnimal { get; set; }

    public Animal(string Nome, string Raça, Classe ClasseAnimal)
    {
    this.Nome = Nome;
    this.Raça = Raça;
    this.ClasseAnimal = ClasseAnimal;
    }
    public void Exibirdetalhes()
    {
        Console.WriteLine($"Nome:{Nome}");
        Console.WriteLine($"Raça:{Raça}");
        Console.WriteLine($"Classe:{ClasseAnimal.nomeclasse}");
    }
}

public class program
{
    static void Main()
    {
        Classe mamifero = new Classe("Mammalia");
        Classe aves = new Classe("Aves");
        Classe repteis = new Classe("Reptilia");
        Classe anfibios = new Classe("Amphibia");

        Animal humanos = new Animal("Humanos", "Homo sapiens", mamifero);
        Animal pinguim = new Animal("Pinguim", "Aptenodytes patagonicus", aves);
        Animal cobra = new Animal("Cobra", "Serpentes", repteis);
        Animal sapo = new Animal("Sapo", "Anura", anfibios);
    }
}
