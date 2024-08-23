using System;
using System.Collections.Generic;

namespace CursoCSharp
{
    /* 6. Declare uma variável do tipo int chamada idade e atribua a ela o valor 25. Em seguida,
declare uma variável do tipo string chamada nome e atribua a ela o seu nome.
Imprima ambos os valores no console. */

    /* public class Variavel
    {
        public static void Main(string[] args)
        {
            int idade = 21;
            string nome = "Davi Giani";

            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Nome: {nome}");
        }

    } */

    /* 7. Crie um método que receba dois parâmetros do tipo int e retorne a soma desses números. Chame esse método em Main e exiba o resultado. */
    public class Soma
    {
        public static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
        }
    }
}