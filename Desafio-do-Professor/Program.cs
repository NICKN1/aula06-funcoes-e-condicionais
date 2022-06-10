// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    double imc = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);
    if(imc < 18.5){
        return "Anêmico";
    }
    else if(imc < 24.9) {
        return "Normal";
    }
    else if(imc < 29.9) {
        return "Sobreso";
    }
    else if(imc > 30 && imc < 40) {
        return "Obesidade";
    }
    else{
        return "Obesidade grave";
    }
}

// Utilize a mensagem a seguir como base do retorno esperado:
// Seu diagnóstico é XXXXXX.
Console.WriteLine("Digite sua altura em metros e seu peso respectivamente:");
Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(double.Parse(Console.ReadLine()),double.Parse(Console.ReadLine()))} ");
