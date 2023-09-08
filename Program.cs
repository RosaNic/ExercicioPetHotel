Console.WriteLine
    ("Ficha de entrada");

Console.WriteLine
    ("Informe o nome da espécie");

String especie = Console.ReadLine()!;

Console.WriteLine
    ("Informe a raça");

String raca = Console.ReadLine()!;

Console.WriteLine
    ("Informe a alcunha do pet");

String alcunha = Console.ReadLine()!;

Console.WriteLine
    ("Informe idade");

String idade = Console.ReadLine()!;

Console.WriteLine
    ("Informe a pelagem");

String pelagem = Console.ReadLine()!;

Console.WriteLine
    ("");

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine
    ("+==========================================================+");

Console.Write
    ("|                  ");

Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write
        ("Pet Hotel \"Nem um piu\"");

Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine
        ("                  |");

Console.WriteLine
    ("+==========================================================+");

Console.Write
        ("|");
Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write
        ("Espécie: ");
Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write
        (especie.ToUpper().PadLeft(21, '_'));

Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write
        (" |");
Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write
        ("Raça: ");

Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write
        (raca.ToUpper().PadLeft(20,'_'));
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine
        ("|");

Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine
        ("+==========================================================+");

Console.Write
    ("|");
Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write
        ("Atende pela alcunha de: ");
Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write
        (alcunha.ToUpper().PadLeft(34,'_'));
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine
        ("|");

Console.WriteLine
    ("+==========================================================+");

Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write
        ("|");
Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write
        ("Idade: ");
Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write
        (idade.ToUpper().PadLeft(10,'_') + " anos(s)");
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write
        ("|");

Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write
        ("Pelagem: ");
Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write
        (pelagem.ToUpper().PadLeft(23,'_'));
Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine
        ("|");
Console.WriteLine
    ("+==========================================================+");