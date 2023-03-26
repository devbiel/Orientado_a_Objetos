using System;

namespace _01Conceitos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Instanciar um objeto ou Criando um objetivo
            Pessoa obj = new Pessoa();
            obj.nome = "Ralf";
            obj.idade = 30;
            obj.mensagem();
        }
    }
}