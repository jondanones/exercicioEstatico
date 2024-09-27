using exercicioEstatico;
using System.Globalization;

Console.Write("Qual é a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantos dólares você vai comprar? ");
double dolares = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double reais = ConversorDeMoeda.Operacao(cotacao, dolares);

Console.WriteLine("Valor a ser pago em reais = " +reais.ToString("F2", CultureInfo.InvariantCulture));