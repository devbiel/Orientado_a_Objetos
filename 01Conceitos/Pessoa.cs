using System;

class Pessoa
{
    //Atributos ou Variávies
    public string? nome;
    public int idade;

    //Métodos ou Função
    public void mensagem()
    {
        Console.WriteLine("Olá "+nome+" você tem "+idade+" Anos!");
    }
}