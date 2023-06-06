using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main(string[] args)
    {
        int health = 3, maxhealth = 5;
        ShowBar(health, maxhealth, ConsoleColor.Red, 0);
        int mana = 2, maxmana = 5;
        ShowBar(mana, maxmana, ConsoleColor.Blue, 2);
    }
    private static void ShowBar(int value, int maxvalue, ConsoleColor color, int position)
    {
        Console.SetCursorPosition(0, position);
        Console.Write("[");

        PrintColoredChar(' ', value, color);

        PrintColoredChar(' ', maxvalue - value, Console.BackgroundColor);

        Console.WriteLine("]");
    }

    private static void PrintColoredChar(char symbol, int count, ConsoleColor backgroungColor)
    {
        ConsoleColor oldColor = Console.BackgroundColor;
        string bar = new string(symbol, count);
        
        Console.BackgroundColor = backgroungColor;
        Console.Write(bar);
        Console.BackgroundColor = oldColor;
    }
}
