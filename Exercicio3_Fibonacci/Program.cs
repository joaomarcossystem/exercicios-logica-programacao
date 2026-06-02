using System;

namespace Exercicio3_Fibonacci;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== LÓGICA DE FIBONACCI =====");

        Console.WriteLine("Digite quantos numeros você deseja ver da sequência de Fibonacci:");
        int qtdNumero = int.Parse(Console.ReadLine());

        int valorAnterior = 0;
        int valorAtual = 1;
        int soma = valorAnterior + valorAtual;

        Console.WriteLine("A sequencia é: ");

        for(int i = 0; i < qtdNumero; i++)
        {
            Console.WriteLine($" {soma}");

            valorAnterior = valorAtual;
            valorAtual = soma;
            soma = valorAnterior + valorAtual;

        }


    }
}