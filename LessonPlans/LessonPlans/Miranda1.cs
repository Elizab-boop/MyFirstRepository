using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace LessonPlans
{
    class Miranda1
    {
        public void RandomFunction()
        {

        }

        public static void Run()
        {
            Console.WriteLine("Miranda - Lesson 1: API Research");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello, My name is Walter.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("Please have a wonderful day!");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("=========================");

        }

        /// <summary>
        /// Sneak peek of something advanced
        /// </summary>
        public static void Run2()
        {
            while (true)
            {
                var colors = Enum.GetValues(typeof(ConsoleColor));

                foreach(ConsoleColor color in colors)
                {
                    if (color == ConsoleColor.Black)
                        continue;
                    Console.ForegroundColor = color;
                    Console.WriteLine("Hi there!");
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();

                }
            }
        }
    }
}
