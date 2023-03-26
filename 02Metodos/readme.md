# Programação Orientado a Objetos

#### Conceitos de rogramção orientado a objetos através da linguagem C#

<p>Nessa aula podemos utilizar vários métodos com o mesmo nome, desde que os parâmetros sejam diferente entre eles..</p>

##### Exemplo:

###### 1. Método 01
    public void apresentar()
    {
        Console.WriteLine("Olá!");
    }

###### 1. Método 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá "+nome);
    }

###### 2. Método 03
    public void apresentar (string nome, int idade)
    {
        Console.WriteLine("Olá "+nome+", você tem "+idade+" anos.");
    }