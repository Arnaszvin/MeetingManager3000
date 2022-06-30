using ConsoleMeetingApp.Display;
using System;

namespace ConsoleMeetingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu display = new DisplayMenu();
            display.Start();
        }
    }
}