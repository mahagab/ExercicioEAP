Console.WriteLine("Informe sua nota:");
int nota = int.Parse(Console.ReadLine());

if (nota >= 7)
{
    Console.WriteLine("Aprovado");
}

else if (nota < 7 && nota >= 4)
{
    Console.WriteLine("Em recuperação");
}

else
{
    Console.WriteLine("Reprovado");
}
