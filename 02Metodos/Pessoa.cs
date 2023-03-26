using System;


// Pode utilizar diversos métodos com o mesmo nome, desde que eles tenham paramêtros diferentes, segue exemplo abaixo:
class Pessoa
{
    // Método 01
    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }

    // Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }

    // Método 03
    public void apresentar (string nome, int idade)
    {
        Console.WriteLine("Olá "+nome+", você tem "+idade+" anos.");
    }
}