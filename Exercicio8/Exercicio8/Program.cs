// Exercicio 8


int c1 = 0;
int c2 = 0;
int c3 = 0;
int c4 = 0;
int c5 = 0;

int voto = 0;

while (voto != 6)
{

    Console.WriteLine("                     URNA ELEITORAL \n" +
        "       DIGITE O NÚMERO DO SEU CANDIDATO:  \n" +
        "               1. Jucelino  \n" +
        "               2. Luladrão\n" +
        "               3. Bozo Mito\n" +
        "               4. Marina\n" +
        "               5. Nulo\n" +
        "               6. Encerrar processo");
    voto = int.Parse(Console.ReadLine());

    if (voto == 1)
    {

        c1++;
        Console.Clear();
        Console.WriteLine($"\n\n\nVoto confirmado em Jucelino . Obrigado\n\n\n");
        continue;

    }
    else if (voto == 2)
    {
        Console.Clear();
        c2++;
        Console.WriteLine($"\n\n\nVoto confirmado em Luladrão. Obrigado\n\n\n");
    }

    else if (voto == 3)
    {
        Console.Clear();
        c3++;
        Console.WriteLine($"\n\n\nVoto confirmado em Bozo Mito. Obrigado\n\n\n");
    }

    else if (voto == 4)
    {
        Console.Clear();
        c4++;
        Console.WriteLine($"\n\n\nVoto confirmado em Marina. Obrigado\n\n\n");
    }

    else if (voto == 5)
    {
        Console.Clear();
        c5++;
        Console.WriteLine($"\n\n\nVoto em Branco confirmado. Obrigado\n\n\n");
    }

    else if (voto == 6)
    {
        Console.Clear();
        Console.WriteLine($"   Votações Encerradas!!!!!!\n" +
            $"Votos:\n  Jucelino : {c1}\n  Luladrão: {c2}\n  Bozo Mito: {c3}\n  Marina: {c4}\n  Nulo/Branco: {c5}");
        break;
    }

}

if (c1 > c2 && c1 > c3 && c1 > c4)
{

    Console.WriteLine($"\n\n               O Vencedor da ELEIÇÃO foi: Jucelino com {c1} votos ");


}
else if (c2 > c1 && c2 > c3 && c2 > c4)
{
    Console.WriteLine($"\n\n               O Vencedor da ELEIÇÃO foi: Luladrão com {c2} votos ");

}
else if (c3 > c1 && c3 > c1 && c3 > c4)
{
    Console.WriteLine($"\n\n               O Vencedor da ELEIÇÃO foi: Bozomito com {c3} votos ");

}
else if (c4 > c1 && c4 > c3 && c4 > c2)
{
    Console.WriteLine($"\n\n               O Vencedor da ELEIÇÃO foi: Marina com {c4} votos ");

}

decimal porcentagem = c5 * 100;

int total_votos = c1 + c2 + c3 + c4 + c5;

decimal nulo = porcentagem / total_votos;


Console.WriteLine($"\n\n               A porcentagem de votos nulos/brancos é de: {nulo} ");
