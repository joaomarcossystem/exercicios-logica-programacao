using Exercicio1_CalculadoraSalarial.Models;
using System;

namespace Exercicio1_CalculadoraSalarial
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("===== CALCULADORA SALARIAL =====\n");


            while (true)
            {
                try
                {
                    Console.Write("\nDigite o valor da hora trabalhada: ");
                    decimal valorSalarioHora = decimal.Parse(Console.ReadLine());

                    Console.Write("\nDigite a quantidade de horas trabalhadas: ");
                    decimal horasTrabalhadasMensal = decimal.Parse(Console.ReadLine());

                    Console.Write("\nDigite a quantidade de filhos menores de 14 anos: ");
                    int filhosMenoresQuatorze = int.Parse(Console.ReadLine());

                    if(valorSalarioHora < 0 || filhosMenoresQuatorze < 0 || horasTrabalhadasMensal < 0)
                    {
                        Console.WriteLine("Digite valores positivos.");
                        continue;
                    }

                    Empregado empregado = new Empregado(valorSalarioHora, horasTrabalhadasMensal, filhosMenoresQuatorze);

                    Console.WriteLine("\n--- RESULTADO ---");
                    Console.WriteLine("O SALÁRIO BRUTO É: " + empregado.CalcularSalarioBruto().ToString("C"));
                    Console.WriteLine("O SALÁRIO FAMÍLIA É: " + empregado.CalcularSalarioFamilia().ToString("C"));
                    Console.WriteLine("O SALÁRIO LÍQUIDO É: " + empregado.CalcularSalarioLiquido().ToString("C"));
                    Console.WriteLine("-----------------\n");

                    Console.WriteLine("Deseja calcular o salário de outro empregado? (S/N)");
                    string escolha = Console.ReadLine().ToUpper();

                    if(escolha != "S")
                    {
                        Console.WriteLine("===APLICAÇÃO FINALIZADA====");
                        break;
                    }

                  
                }
                catch (FormatException)
                {
                    Console.WriteLine("\n[Erro] Formato inválido. Por favor, digite apenas números.");
                }
            }
            

        }
    }
}