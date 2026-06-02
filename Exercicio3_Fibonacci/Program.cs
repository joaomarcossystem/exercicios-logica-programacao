using System;

namespace Exercicio3_Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== LÓGICA DE FIBONACCI =====");

            while (true)
            {
                try
                {
                    Console.WriteLine("\nDigite quantos numeros você deseja ver da sequência de Fibonacci:");
                    int qtdNumero = int.Parse(Console.ReadLine());

                    if (qtdNumero <= 0)
                    {
                        Console.WriteLine("\n[Aviso] Por favor, digite um número maior que zero.\n");
                        return;
                    }

                    // Chama o metodo de imprimir sequencia
                    ImprimirSequencia(qtdNumero);

                    // Chama o metodo de verificação
                    VerificarPertencimento(qtdNumero);

                    Console.WriteLine("\nDeseja escolher outro número? (S/N)");
                    string resposta = Console.ReadLine().ToUpper();

                    if(resposta != "S")
                    {
                        Console.WriteLine("=== APLICAÇÃO FINALIZADA ====");
                        break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n[Erro] Formato inválido. Digite apenas números inteiros.");
                }
            }
        }

        // --- MÉTODO PARA IMPRIMIR A SEQUÊNCIA DE ACORDO COM O NÚMERO ESCOLHIDO
        private static void ImprimirSequencia(int qtdNumero)
        {
            int valorAnterior = 1;
            int valorAtual = 1;

            Console.WriteLine("\na) A sequencia é: ");

            for (int i = 0; i < qtdNumero; i++)
            {
                Console.Write($"{valorAnterior}  ");

                int proximo = valorAnterior + valorAtual;
                valorAnterior = valorAtual;
                valorAtual = proximo;
            }
            Console.WriteLine(); // Pula linha no final
        }

        // --- MÉTODO PARA VERIFICAR SE O NÚMERO ESCOLHIDO PERTENCE A SEQUÊNCIA
        private static void VerificarPertencimento(int alvo)
        {
            int valorAnterior = 1;
            int valorAtual = 1;

            // O laço roda silenciosamente até alcançar ou ultrapassar o número alvo
            while (valorAnterior < alvo)
            {
                int proximo = valorAnterior + valorAtual;
                valorAnterior = valorAtual;
                valorAtual = proximo;
            }

            // Se parou exatamente em cima do alvo, ele pertence
            if (valorAnterior == alvo)
            {
                Console.WriteLine($"\nb) O número {alvo} FAZ PARTE da sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"\nb) O número {alvo} NÃO FAZ PARTE da sequência de Fibonacci.");
            }
        }
    }
}