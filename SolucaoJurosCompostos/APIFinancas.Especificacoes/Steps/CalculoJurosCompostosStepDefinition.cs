using System;
using System.Globalization; // Necessário para o CultureInfo
using TechTalk.SpecFlow;
using Xunit;
using APIFinancas;

namespace APIFinancas.Especificacoes.Steps
{
    [Binding]
    public class CalculoJurosCompostosStepDefinition
    {
        private double _valorEmprestimo;
        private int _meses;
        private double _percentualTaxa;
        private double _resultadoCalculo;

        // Alteramos o parâmetro para 'string'
        [Given(@"que o valor do empréstimo é de R\$ (.*)")]
        public void DadoQueOValorDoEmprestimoEDeR(string valorEmprestimo)
        {
            // Substituímos vírgula por ponto (por segurança) e forçamos a leitura no padrão invariante
            _valorEmprestimo = double.Parse(valorEmprestimo.Replace(",", "."), CultureInfo.InvariantCulture);
        }

        [Given(@"que este empréstimo será por (.*) meses")]
        public void DadoQueEsteEmprestimoSeraPorMeses(int meses)
        {
            _meses = meses;
        }

        // Alteramos o parâmetro para 'string'
        [Given(@"que a taxa de juros é de (.*)% ao mês")]
        public void DadoQueATaxaDeJurosEDeAoMes(string percentualTaxa)
        {
            _percentualTaxa = double.Parse(percentualTaxa.Replace(",", "."), CultureInfo.InvariantCulture);
        }

        [When(@"eu solicitar o cálculo do valor total a ser pago ao final do período")]
        public void QuandoEuSolicitarOCalculoDoValorTotalASerPagoAoFinalDoPeriodo()
        {
            _resultadoCalculo = CalculoFinanceiro.CalcularJurosCompostos(_valorEmprestimo, _meses, _percentualTaxa);
        }

        // Alteramos o parâmetro para 'string'
        [Then(@"o resultado será (.*)")]
        public void EntaoOResultadoSera(string valorEsperado)
        {
            double esperado = double.Parse(valorEsperado.Replace(",", "."), CultureInfo.InvariantCulture);
            Assert.Equal(esperado, _resultadoCalculo, 2);
        }
    }
}