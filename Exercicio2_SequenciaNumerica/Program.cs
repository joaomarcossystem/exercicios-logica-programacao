using System;
using System.Runtime.Serialization;

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
            int segundoMaior = int.MinValue;


            for (int i = 0; i < sequencia.Length; i++)
            {
                // Lógica do Menor
                if (sequencia[i] < menor)
                {
                    menor = sequencia[i];
                }

                // Lógica do Maior e Segundo Maior
                if (sequencia[i] > maior)
                {
                    // O antigo maior cai para segundo lugar antes da atualização
                    segundoMaior = maior;
                    maior = sequencia[i];
                }
                else if (sequencia[i] > segundoMaior && sequencia[i] != maior)
                {
                    // Atualiza o segundo maior, garantindo que não é o mesmo valor do maior
                    segundoMaior = sequencia[i];
                }
            }

            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número é: {menor}");
            Console.WriteLine($"O segundo maior é: {segundoMaior}");

            Console.WriteLine();
            Console.WriteLine("===== APLICAÇÃO FINALIZADA =====");

        }

        catch (FormatException)
        {
            Console.WriteLine("\n [ERRO] Digite números válidos.");
        }

    }

}


            /*
            if (sequencia[i] < segundoMaior )
            {
                segundoMaior = sequencia[i] - maior;  >>>> tentativas feitas na entrevista
            }

            /*
            if (segundoMaior < maior)
            {
                segundoMaior  = sequencia[i]; >>>> tentativas feitas na na entrevista
            }
            */