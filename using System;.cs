using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heath_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 3,  maxhealth = 5;
            SomeBar(health, maxhealth, ConsoleColor.Red, 0);
            int mana = 2, maxmana = 5;
            SomeBar(mana, maxmana, ConsoleColor.Blue, 2);
        }
        static void SomeBar (int value, int maxvalue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            string bar = "";
            for (int i = 0; i < value; i++)
            {
                bar += " ";
            }
            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;
            for (int i = value; i < maxvalue; i++) 
            {
                bar += " ";
            }
            Console.WriteLine(bar+ "]");

        }
    }
}