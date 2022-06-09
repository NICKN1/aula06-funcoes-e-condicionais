// Variáveis
double cotacaoDoDolarHoje = 4.97;
// Constantes
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

// Tipo da Função - Nome da Função    PRIMEIRO PARâMETRO           SEGUNDO PARâMETRO
double converterRealParaDolar(double valorDaCompraEmReais, double cotacaoDoDolarHoje)
{
    //PRIMEIRO                //SEGUNDO
    valorDaCompraEmReais /= cotacaoDoDolarHoje;

    // RETORNANDO UM VALOR DO MESMO TIPO QUE FALAMOS NO INICIO DA FUNÇÃO
    return valorDaCompraEmReais;
}

//Inicio do contato com usuário
Console.WriteLine("Digite o valor da compra: ");

//Chamar o método da função  (Os dois parametros)    
double valor = converterRealParaDolar(double.Parse(Console.ReadLine()), cotacaoDoDolarHoje);
//Dentro do primeiro parametro coloquei a informação que o usuário irá digitar
//Usado o double.Parse para converter o String(texto) do usuário para um tipo double(Decimal) 

//Aqui se inicia a cadeia de Condições
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
    // Usei o ToString para converter a variável 'valor' em String com o objetivo de limitar as casas decimais após o zero
    Console.WriteLine($"Você pode comprar $ {valor.ToString("N2")}");
}