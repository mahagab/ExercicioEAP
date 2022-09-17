//Exercicio 6
Console.WriteLine("Insira um número: ");

int N = 1, P;
P = int.Parse(Console.ReadLine());



while (P != 1)
{
    if (P == 0)
    {
        int X = 1;
        Console.WriteLine($"O resuldado é de {X}");
        break;
    }

    N = N * P;
    
    P--;

}
Console.WriteLine($"O valor do fatorial é de: {N}");