using System;

namespace APIFinancas
{
    public static class CalculoFinanceiro
    {
        public static double CalcularJurosCompostos(double valorEmprestimo, int meses, double percentualTaxa)
        {
            // Converte a taxa de porcentagem para decimal (ex: 4% vira 0.04)
            double taxaDecimal = percentualTaxa / 100.0;
            
            // Aplica a fórmula matemática dos juros compostos
            double montante = valorEmprestimo * Math.Pow((1 + taxaDecimal), meses);
            
            // CORREÇÃO 1: Arredonda o resultado final para 2 casas decimais
            return Math.Round(montante, 2);
        }
    }
}