using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio1_CalculadoraSalarial.Models
{
    public class Empregado
    {
        public decimal ValorSalarioHora { get; private set; }
        public decimal HorasTrabalhadasMensal { get; private set; }
        public int FilhosMenorQuatorze { get; private set; }

        public Empregado(decimal valorSalarioHora, decimal horasTrabalhadasMensal, int filhosMenorQuatorze)
        {
            ValorSalarioHora = valorSalarioHora;
            HorasTrabalhadasMensal = horasTrabalhadasMensal;
            FilhosMenorQuatorze = filhosMenorQuatorze;
        }

        public decimal CalcularSalarioBruto()
        {
            return ValorSalarioHora * HorasTrabalhadasMensal;
        }

        public decimal CalcularSalarioFamilia()
        {
            if (CalcularSalarioBruto() <= 788.0m)
            {
                return 30.5m * FilhosMenorQuatorze;
            }
            else if (CalcularSalarioBruto() > 788.0m && CalcularSalarioBruto() <= 1100.0m)
            {
                return 18.5m * FilhosMenorQuatorze;
            }
            else
            {
                return 11.9m * FilhosMenorQuatorze;
            }

        }

        public decimal CalcularSalarioLiquido()
        {
            return CalcularSalarioBruto() + CalcularSalarioFamilia();
        }

    }
}