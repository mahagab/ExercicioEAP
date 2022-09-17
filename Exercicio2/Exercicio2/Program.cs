Console.WriteLine("Informe o primeiro valor:");
int valor1 = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor:");
int valor2 = int.Parse(Console.ReadLine());

if (valor1 > valor2 && valor1 % valor2 == 0)
{
    Console.WriteLine("São múltiplos");
}

else if (valor2 > valor1 && valor2 % valor1 == 0)
{
    Console.WriteLine("São múltiplos");
}

else
{
    Console.WriteLine("Não são multiplos");
}
