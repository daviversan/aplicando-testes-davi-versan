#language: pt

Funcionalidade: Calculo de Juros Compostos
  Como um usuario do sistema financeiro
  Eu quero calcular os juros compostos de um emprestimo
  Para saber o valor total a ser pago ao final do periodo

Cenario: Simulacao Juros Compostos 02
  Dado que o valor do empréstimo é de R$ 11937.28
  E que este empréstimo será por 24 meses
  E que a taxa de juros é de 4.00% ao mês
  Quando eu solicitar o cálculo do valor total a ser pago ao final do período
  Então o resultado será 30598.88


#language: pt

Funcionalidade: Calculo de Juros Compostos
  Como um usuario do sistema financeiro
  Eu quero calcular os juros compostos de um emprestimo
  Para saber o valor total a ser pago ao final do periodo

Cenario: Simulacao Juros Compostos 02
  Dado que o valor do empréstimo é de R$ 11937.28
  E que este empréstimo será por 24 meses
  E que a taxa de juros é de 4.00% ao mês
  Quando eu solicitar o cálculo do valor total a ser pago ao final do período
  Então o resultado será 30598.88

Cenario: Simulacao Juros Compostos 03 (Longo Prazo)
  Dado que o valor do empréstimo é de R$ 5000.00
  E que este empréstimo será por 12 meses
  E que a taxa de juros é de 2.50% ao mês
  Quando eu solicitar o cálculo do valor total a ser pago ao final do período
  Então o resultado será 6724.44