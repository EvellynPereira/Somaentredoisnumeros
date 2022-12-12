Console.WriteLine("Soma entre dois números");

Console.WriteLine("Digite um número:");
string um = Console.ReadLine()!;
decimal decimalString1 = Convert.ToDecimal(um);

Console.WriteLine("Digite outro número:");
string dois = Console.ReadLine()!;
decimal decimalString12 = Convert.ToDecimal(dois);

decimal resultado = decimalString1 + decimalString12;

Console.WriteLine("Seu resultado é:");
Console.Beep(1320, 1000);
Console.WriteLine($"{resultado}");
