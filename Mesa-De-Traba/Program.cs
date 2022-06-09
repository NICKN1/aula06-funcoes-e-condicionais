// Variáveis
double cotacaoDoDolarHoje = 4.97;
// Constantes
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

// Função
double converterRealParaDolar(double valorDaCompraEmReais, double cotacaoDoDolarHoje)
{
    valorDaCompraEmReais /= cotacaoDoDolarHoje;

    return valorDaCompraEmReais;
}

Console.WriteLine("Digite o valor da compra: ");

//Chamar o método da função  (Os dois parametros)
double valor = converterRealParaDolar(int.Parse(Console.ReadLine()), cotacaoDoDolarHoje);


if (valor < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine($"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}");
}
else if (valor > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine($"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}");
}
else
{
    Console.WriteLine($"Você pode comprar $ {valor.ToString("N2")}");
}