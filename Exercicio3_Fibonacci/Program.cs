using System;

namespace Exercicio3_Fibonacci
{
    class Program
    {
        public static void Main(string[] args)
        {
            // mudança da lógica de fibonnaci:
            // verificar se é impar > se for, somar os três numeros anteriores > se for par, mantém a lógica normal
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
                        continue;
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

        // MÉTODO PARA IMPRIMIR A SEQUÊNCIA DE ACORDO COM O NÚMERO ESCOLHIDO
        private static void ImprimirSequencia(int qtdNumero)
        {
            int antepenultimo = 0;
            int penultimo = 0;
            int atual = 1;

            Console.WriteLine("\n A sequencia é: ");

            for (int i = 0; i < qtdNumero; i++)
            {
                Console.Write($"{atual}  ");

                int proximo;

                
                if (atual % 2 != 0) // verificar se é impar
                {
                    proximo = antepenultimo + penultimo + atual; // Soma os 3 últimos
                }
                else
                {
                    proximo = penultimo + atual; // mantem a lógica caso for par
                }

                antepenultimo = penultimo;
                penultimo = atual;
                atual = proximo;
            }

            Console.WriteLine(); // Pula linha no final
        }

        // MÉTODO PARA VERIFICAR SE O NÚMERO ESCOLHIDO PERTENCE A SEQUÊNCIA
        private static void VerificarPertencimento(int alvo)
        {
            int antepenultimo = 0;
            int penultimo = 0;
            int atual = 1;


            while (atual < alvo)
            {
                int proximo;

                if (atual % 2 != 0) // Ímpar
                {
                    proximo = antepenultimo + penultimo + atual;
                }
                else // Par
                {
                    proximo = penultimo + atual;
                }

                antepenultimo = penultimo;
                penultimo = atual;
                atual = proximo;

            }

            // Se parou exatamente em cima do alvo, ele pertence
            if (atual == alvo)
            {
                Console.WriteLine($"\n O número {alvo} FAZ PARTE da sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"\n O número {alvo} NÃO FAZ PARTE da sequência de Fibonacci.");
            }
        }
    }
}

                /*
                for (int i = 0; i < qtdNumero; i++)
                {
                    Console.Write($"{valorAnterior}  ");

                    int proximo = valorAnterior + valorAtual;  >>>> TENTATIVAS FEITAS NA ENTREVISTA <<<<
                    valorAnterior = valorAtual;
                    valorAtual = proximo;
                }
                */


                /*int proximo = valorAnterior + valorAtual; 
                if(proximo == ()) // validação numero ímpar 
                {                                            >>>>TENTATIVAS FEITAS NA ENTREVISTA<<<<
                    valorAnterior = valorAtual;             
                    valorAtual = proximo;                   
                }*/