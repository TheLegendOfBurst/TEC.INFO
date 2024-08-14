using System;

namespace CursoCSharp
{
    public class ExerciciosArrays
    {
        /* public static void Exercicio1()
        {
            int[] numeros = { 2, 4, 6, 8, 10 };
            foreach (int numero in numeros)
            {
                Console.WriteLine($"Os numeros foram {numero}");
            }
        } */

        /* public static void Exercicio2()
        {
            int[] valores = { 1, 3, 5, 7, 9 };
            Console.WriteLine($"O terceiro elemento do array é: {valores[2]}");
        } */

        /* public static void Exercicio3()
        {
            string[] nomes = { "Ana", "Bruno", "Carla" };
            nomes[1] = "Beto";
            foreach (string nome in nomes)
            {
                Console.WriteLine($"Nome: {nome}");
            }
        } */

        /* public static void Exercicio4()
        {
            int[] notas = { 7, 8, 9, 10, 6 };
            int soma = 0;
            foreach (int nota in notas)
            {
                soma += nota;
                }
                Console.WriteLine($"A soma dos elementos do array é: {soma}");
        } */
        
        public static void Exercicio5()
        {
            int[] numeros = { 5, 10, 15, 20, 25 };
            bool encontrado = false;
            foreach (int numero in numeros)
            {
                if (numero == 15)
                {
                    encontrado = true;
                    break;
                }
            }
            if (encontrado)
            {
                Console.WriteLine("O número 15 está presente no array.");
            }
            else
            {
                Console.WriteLine("O número 15 não está presente no array.");
            }
        }
    }
}