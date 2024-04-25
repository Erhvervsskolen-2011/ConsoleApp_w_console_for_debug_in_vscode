// See https://aka.ms/new-console-template for more information
Console.Write("Hello, Søren!\n");

Console.WriteLine("Det er en dejlig dag!");

// Pos

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

Console.SetCursorPosition(0,0);
Console.WriteLine("Øverst i venstre side");

Console.WriteLine($"WindowHeight: {Console.WindowHeight}");
Console.WriteLine($"WindowWidth : {Console.WindowWidth}");

int MidtX = Console.WindowWidth / 2;
int MidtY = Console.WindowHeight / 2;

string midtMsg = "Midten";

Console.SetCursorPosition(MidtX - (midtMsg.Length/2), MidtY);
Console.Write(midtMsg);

string bundMsg = "Nederst til højre";

Console.SetCursorPosition(Console.WindowWidth - bundMsg.Length, Console.WindowHeight - 1);
Console.Write(bundMsg);
 
