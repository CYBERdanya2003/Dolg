using System;

class Program
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Лунная ночь");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"Будет луна.
Есть уже
немножко.
А вот и полная повисла в воздухе.
Это Бог, должно быть,
дивной
серебряной ложкой
роется в звёзд ухе.");
        Console.ReadKey();
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }
}