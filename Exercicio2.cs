using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    /* 6. Declare uma variável do tipo int chamada idade e atribua a ela o valor 25. Em seguida,
    declare uma variável do tipo string chamada nome e atribua a ela o seu nome.
    Imprima ambos os valores no console. 

     public class Variavel
    {

        public int idade = 21;
        public string? nome = "Davi Giani";
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}, Idade: {idade}");
        }

        /* 7. Crie um método que receba dois parâmetros do tipo int e retorne a soma desses
        números. Chame esse método em Main e exiba o resultado. 

        public void Soma(int numero1, int numero2)
        {
            int somaNum = numero1 + numero2;  
            Console.WriteLine($"O Resultado da soma foi {somaNum}");
        }
        
        /* 8. Declare uma variável do tipo bool chamada estaChovendo e atribua a ela o valor false.
        Escreva uma estrutura condicional que exiba “Está chovendo” ou “Não está chovendo”
        com base no valor da variável. 

        public bool estaChovendo = false;
        public void ExibirEstaChovendo()
        {
            if (estaChovendo)
            {
                Console.WriteLine("Está chovendo");
            }
            else
            {
                Console.WriteLine("Não está chovendo");
            }
        }

        /* 9. Implemente um método chamado VerificarMaioridade que recebe uma idade como
            parâmetro e retorna true se a idade for maior ou igual a 18, e false caso contrário.
            Teste esse método no método Main.(bool resultado = objeto.VerificarIdade) 
        
        public bool VerificarMaioridade(int idade)
        {
            if (idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        /* 10. Declare uma variável do tipo double chamada altura e atribua a ela o valor 1.75.
            Imprima o valor no console formatado para duas casas decimais.

        public double altura = 1.75;
        public void ExibirAltura()
        {
            Console.WriteLine($"Altura formatada: {altura.ToString("N2")}");
        }

    } */

    public class Sobrecarga
    {
        /* 11. Crie um método CalcularArea que calcule a área de um círculo recebendo o raio como
        parâmetro e retorne o resultado. Use a fórmula Área = π * raio^2. */

        public void CalcularArea(double raio)
        {
            //double area = Math.PI * Math.Pow(raio, 2);
            double area = Math.PI * raio * raio;
            Console.WriteLine($"Área do círculo: {area.ToString("N2")}");
        }

        /* 12. Sobrecarga de métodos: Crie uma sobrecarga do método CalcularArea para calcular a
        área de um retângulo, recebendo a largura e a altura como parâmetros. */

        public void CalcularArea(double largura, double altura)
        {

            double area = altura * largura;
            Console.WriteLine($"Área do retângulo: {area.ToString("N2")}");
        }

    }


}