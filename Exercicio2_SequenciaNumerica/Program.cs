using System;

namespace Exercicio2_SequenciaNumerica;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== SEQUÊNCIA NUMÉRICA =====");

        try
        {
            Console.WriteLine("\nDigite a quantidade de números que sua sequência possuirá.");
            int qtdNumeros = int.Parse(Console.ReadLine());

            int[] sequencia = new int[qtdNumeros];

            Console.WriteLine("\nAgora digite os numeros da sequencia: \n");

            for(int i = 0; i < qtdNumeros; i++)
            {
                Console.WriteLine($"Digite o {i+1}° número");
                sequencia[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n ------RESULTADO------\n");
            Console.WriteLine("Sequência digitada: ");
            for(int i = 0; i < sequencia.Length; i++)
            {
                Console.Write(sequencia[i] + "; ");
            }

            Console.WriteLine(""); // apenas para pular uma linha

            int menor = sequencia[0];
            int maior = sequencia[0]; //assumir que o primeiro elemento é o menor e o maior valor

            for(int i = 0; i < sequencia.Length; i++)
            {
                if (sequencia[i] < menor)
                {
                    menor = sequencia[i];
                }
                if (sequencia[i] > maior)
                {
                    maior = sequencia[i];
                }
            }

            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");

            Console.WriteLine();
            Console.WriteLine("===== APLICAÇÃO FINALIZADA =====");



        }
        catch (FormatException)
        {
            Console.WriteLine("\n [ERRO] Digite números válidos.");
        }

    }

}