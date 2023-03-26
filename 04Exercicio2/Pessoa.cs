using System;

class Pessoa
{
    // Atributos
    public double peso, altura;

    // Calculo
    public double imc()
    {
        return peso / (altura*altura) ;
    }

    // Situação
    public string resultadoimc(double imc)
    {
        if (imc < 18.5){
            return "Abaixo do peso";
        }
        else if (imc < 25){
            return "Peso normal";
        }
        else if (imc < 30){
            return "Acima do peso";
        }
        else if (imc < 35){
            return "Obesidade I";
        }
        else if (imc < 40){
            return "Obesidade II";
        }
        else {
            return "Obesidade III";
        }
    }

    // Mensagem
    public void mensagem()
    {
        // Obter o IMC
        double obterIMC = imc();

        // Obter o resultado
        string obterResultado = resultadoimc(obterIMC);

        // Escrever mensagem
        Console.WriteLine("Seu IMC é "+obterIMC+" e de acordo com ele, você está "+ obterResultado);
    }
}