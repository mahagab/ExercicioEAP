Console.WriteLine("Informe uma estimativa de nota otimista:");
double ots = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a estimativa de nota pessimista:");
double pes = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a estimativa de nota mais provável:");
double prv = double.Parse(Console.ReadLine());

Console.WriteLine($"Nota Otimista: {ots}");
Console.WriteLine($"Nota Pessimista: {pes}");
Console.WriteLine($"Nota Provavel: {prv}");
Console.WriteLine($"Média Final: {(ots + pes + (4 * prv)) / 6}");

