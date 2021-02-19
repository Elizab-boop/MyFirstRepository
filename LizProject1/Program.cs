using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LizProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunny bunny = new Bunny("green");
            WriteSlowMessage(bunny.FullSummaryBunny());
            Console.ReadKey();
        }
        static void MultiMenu()
        {
            string input = string.Empty;

            bool shouldRun = true;

            while (shouldRun)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                WriteSlowMessage("GIF2");
                Console.WriteLine();
                WriteSlowMessage("Global Integrated Fulfillment");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
                WriteSlowMessage("Open\t" + "y/n");
                Console.WriteLine();
                Console.WriteLine();

                input = Console.ReadLine();

                switch (input)
                {
                    case "y":
                        WriteSlowMessage("Application Starting");
                        break;

                    case "n":
                        Console.WriteLine();
                        WriteSlowMessage("Application Closed");
                        shouldRun = false;
                        break;
                }

                while (input != "n")
                {
                    PickingMenu();

                    WriteSlowMessage("Return to main menu?");
                    Console.WriteLine();
                    WriteSlowMessage("y/n");
                    Console.WriteLine();

                    input = Console.ReadLine();
                }

                Console.ReadKey();
            }
        }
        static void Exceptions()
        {
            Console.Clear();
            Console.WriteLine("Pick Exceptions");
        }
        static void Staging()
        {
            Console.Clear();
            Console.WriteLine("Staging");
        }
        static void Picking()
        {
            Console.Clear();
            Console.WriteLine("Ambient\t" + "1");
            Console.WriteLine("Chilled\t" + "1");
            Console.WriteLine("General\t" + "1");
            Console.WriteLine();

        }
        static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Picking\t\t" + "3");
            Console.WriteLine("Exceptions\t" + "1");
            Console.WriteLine("Staging");
            Console.WriteLine();
        }
        static void PickingMenu()
        {
            MainMenu();
            string input = string.Empty;
            input = Console.ReadLine();

            if (input == "Picking")
            {
                Picking();

                input = Console.ReadLine();

                switch (input)
                {
                    case "Ambient":
                        Console.Clear();
                        Console.WriteLine("A7 17 25");
                        WriteSlowMessage("JIF Creamy Peanut Butter");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Pick\t" + "Item Not Found");
                        break;

                    case "Chilled":
                        Console.Clear();
                        Console.WriteLine("A31 6 17");
                        WriteSlowMessage("Great Value Biscuits");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Pick\t" + "Item Not Found");
                        break;

                    case "General":
                        Console.Clear();
                        Console.WriteLine("G22 6 34");
                        WriteSlowMessage("Herbal Essences Shampoo");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Pick\t" + "Item Not Found");
                        break;
                }
                input = Console.ReadLine();

                if (input == "Pick")
                {
                    Console.Clear();
                    WriteSlowMessage("Pick Successful!");
                    Console.WriteLine();
                }
                else if (input == "Item Not Found")
                {
                    WriteSlowMessage("Nothing to see here.");
                    Console.WriteLine();
                }
                else
                {
                    WriteSlowMessage("Invalid Choice");
                    Console.WriteLine();
                }
            }
            else if (input == "Exceptions")
            {
                Exceptions();
            }
            else if (input == "Staging")
            {
                Staging();
            }
        }

            
        private static int waitTime = 50;
        private static void WriteSlowMessage(string message)
        {
            foreach (char c in message)
            {
                if (Console.KeyAvailable)
                    waitTime = 0;

                Console.Write(c);

                if (waitTime != 0)
                    System.Threading.Thread.Sleep(waitTime);
            }
        }
        static void LizAB3()
        {
            string input = string.Empty;

            while (input.ToLower() != "fuck off")
            {
                Console.Clear();
                Console.WriteLine("TODAY'S MENU!");
                Console.WriteLine("1\t" + "Soup");
                Console.WriteLine("2\t" + "Sandwich");
                Console.WriteLine("3\t" + "AVOCADO TOAST");
                Console.WriteLine("4\t" + "An Aged Carcass");
                Console.WriteLine("5\t" + "Diet Coke");
                Console.WriteLine("What is your order?");

                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("NO SOUP FOR YOU!");
                        break;
                    case "2":
                        Console.WriteLine("Sorry, we are out of bread.");
                        break;
                    case "3":
                        Console.WriteLine("Dirty hipster.");
                        break;
                    case "4":
                        Console.WriteLine("What is wrong with you?");
                        break;
                    case "5":
                        Console.WriteLine("You'll still be fat if you drink diet.");
                        break;
                    default:
                        Console.WriteLine("We aren't a real restaurant, you fool.");
                        break;
                }
                Console.ReadKey();
            }
        }
        static void LizAB2()
        {
            string input = string.Empty;

            while (input.ToLower() != "fuck off")
            {
                Console.Clear();
                Console.WriteLine("TODAY'S MENU!");
                Console.WriteLine("1\t" + "Soup");
                Console.WriteLine("2\t" + "Sandwich");
                Console.WriteLine("3\t" + "AVOCADO TOAST");
                Console.WriteLine("4\t" + "An Aged Carcass");
                Console.WriteLine("5\t" + "Diet Coke");
                Console.WriteLine("What is your order?");

                input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("NO SOUP FOR YOU!");
                }
                else if (input == "2")
                {
                    Console.WriteLine("Sorry, we are out of bread.");
                }
                else if (input == "3")
                {
                    Console.WriteLine("Dirty hipster.");
                }
                else if (input == "4")
                {
                    Console.WriteLine("What is wrong with you?");
                }
                else if (input == "5")
                {
                    Console.WriteLine("You'll still be fat if you drink diet.");
                }
                else
                {
                    Console.WriteLine("We aren't a real restaurant, you fool.");
                }
                Console.ReadKey();
            }
        }
        static void LizAB()
        {
            string input = string.Empty;

            while (input.ToLower() != "fuck off")
            {
                Console.Clear();
                Console.WriteLine("TODAY'S MENU!");
                Console.WriteLine("-" + "Soup");
                Console.WriteLine("-" + "Sandwich");
                Console.WriteLine("-" + "AVOCADO TOAST");
                Console.WriteLine("-" + "An Aged Carcass");
                Console.WriteLine("-" + "Diet Coke");
                Console.WriteLine("What is your order?");

                input = Console.ReadLine();

                if (input.ToLower() == "soup")
                {
                    Console.WriteLine("NO SOUP FOR YOU!");
                }
                else if (input.ToLower() == "sandwich")
                {
                    Console.WriteLine("Sorry, we are out of bread.");
                }
                else if (input.ToUpper() == "AVOCADO TOAST")
                {
                    Console.WriteLine("Dirty hipster.");
                }
                else if (input.ToLower() == "an aged carcass")
                {
                    Console.WriteLine("What is wrong with you?");
                }
                else if (input.ToLower() == "diet coke")
                {
                    Console.WriteLine("You'll still be fat if you drink diet.");
                }
                else
                {
                    Console.WriteLine("We aren't a real restaurant, you fool.");
                }
                Console.ReadKey();
            }
        }
        static void WalterABEx()
        {
            string input = string.Empty;

            while (input.ToLower() != "fuck off")
            {
                Console.Clear(); //doing this here so the next loop clears the window
                Console.WriteLine("Choose an option:");
                Console.WriteLine("A");
                Console.WriteLine("B");

                input = Console.ReadLine();

                if (input.ToUpper() == "A")
                {
                    Console.WriteLine("You have selected A!");
                }
                else if (input.ToUpper() == "B")
                {
                    Console.WriteLine("You have selected B!");
                }
                else
                {
                    Console.WriteLine("Be my friend?");
                }
            }
        }
        /// <summary>
        /// All prompts together.
        /// </summary>
        static void AllPromts()
        {
            int value = GetNumber();
            int valuetwo = GetAnotherNumber();
            int valuethree = GetAThirdNumber();
            int valuefour = GetAFourthNumber();
            int valuefive = GetAFifthNumber();
            int total = AddNumbers(value, valuetwo);
            Console.WriteLine(total);
            int totaltwo = MultiplyNumbers(valuetwo, valuethree);
            Console.WriteLine(totaltwo);
            int totalthree = DivideNumbers(valuefour, valuethree);
            Console.WriteLine(totalthree);
            int totalfour = AddFiveNumbers(value, valuetwo, valuethree, valuefour, valuefive);
            Console.WriteLine(totalfour);
            Console.ReadKey();
        }
        /// <summary>
        /// All four prompts separately.
        /// </summary>
        static void EachPrompt()
        {
            int value = GetNumber();
            int othervalue = GetAnotherNumber();
            int total = AddNumbers(value, othervalue);
            Console.WriteLine(total);
            Console.WriteLine();

            int value2 = GetAnotherNumber();
            int value3 = GetAThirdNumber();
            int total2 = MultiplyNumbers(value2, value3);
            Console.WriteLine(total2);
            Console.WriteLine();

            int value4 = GetAFourthNumber();
            int value5 = GetAThirdNumber();
            int total3 = DivideNumbers(value4, value5);
            Console.WriteLine(total3);
            Console.WriteLine();

            int value6 = GetNumber();
            int value7 = GetAnotherNumber();
            int value8 = GetAThirdNumber();
            int value9 = GetAFourthNumber();
            int value10 = GetAFifthNumber();
            int total4 = AddFiveNumbers(value6, value7, value8, value9, value10);
            Console.WriteLine(total4);
        }
        /// <summary>
        /// Adds five numbers together.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <param name="C"></param>
        /// <param name="D"></param>
        /// <param name="E"></param>
        /// <returns></returns>
        static int AddFiveNumbers(int A, int B, int C, int D, int E)
        {
            return (A + B + C + D + E);
        }
        /// <summary>
        /// Divide one number by another.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static int DivideNumbers(int A, int B)
        {
            return (A / B);
        }
        /// <summary>
        /// Multiplies two numbers together.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static int MultiplyNumbers(int A, int B)
        {
            return (A * B);
        }
        /// <summary>
        /// Gets a fifth number.
        /// </summary>
        /// <returns></returns>
        static int GetAFifthNumber()
        {
            return 13;
        }
        /// <summary>
        /// Gets a Fourth Number.
        /// </summary>
        /// <returns></returns>
        static int GetAFourthNumber()
        {
            return 36;
        }
        /// <summary>
        /// Gets a third number.
        /// </summary>
        /// <returns></returns>
        static int GetAThirdNumber()
        {
            return 12;
        }
        /// <summary>
        /// Gets a number.
        /// </summary>
        /// <returns></returns>
        static int GetNumber()
        {
            return (int)1.0;
        }
        /// <summary>
        /// Gets a different number.
        /// </summary>
        /// <returns></returns>
        static int GetAnotherNumber()
        {
            return 7;
        }
        /// <summary>
        /// Adds two numbers together.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        static int AddNumbers(int A, int B)
        {
            return A + B;
        }

        /// <summary>
        /// Use reference type to carry changes back to caller.
        /// </summary>
        /// <param name="values"></param>
        static void SquareValues(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i] * values[i];
            }
        }

        /// <summary>
        /// Change value type due to reference call
        /// </summary>
        /// <param name="value"></param>
        static void ChangeReferenceValue(ref int value)
        {
            value = 17;
        }

        static void CreateColorfulListOfNames()
        {
            string[] names = new string[] { "Rachael", "Dale", "Levi", "Megan", "Brad", "Lisa", "Jesse", "Greg", "Geoffry", "Heather" };

            Array colors = Enum.GetValues(typeof(ConsoleColor));

            Console.WriteLine("CLASS LIST");

            for (int i = 0; i < names.Length; i++)
            {
                Console.ForegroundColor = (ConsoleColor)colors.GetValue(i + 1);
                Console.WriteLine(names[i]);
            }
        }

        static void WriteFriendlyMessage()
        {
            Console.WriteLine("You are beautiful!");
        }
        static void MeanMessage()
        {
            Console.WriteLine("You're A Bully!");
        }
        static void ListOfColor()
        {
            string[] names = new string[] { "Rachael", "Dale", "Levi", "Megan", "Brad", "Lisa", "Jesse", "Greg", "Geoffry", "Heather" };
            while (true)
            {
                var colors = Enum.GetValues(typeof(ConsoleColor));
                foreach (ConsoleColor color in colors)
                {
                    if (color == ConsoleColor.Black)
                        continue;
                    Console.ForegroundColor = color;
                    Console.WriteLine("CLASS LIST");
                    foreach (string name in names)
                        Console.WriteLine(name);
                    System.Threading.Thread.Sleep(200);
                    Console.Clear();
                }
            }
        }
        static void DifferentColor()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            string[] names = new string[] { "Rachael", "Dale", "Levi", "Megan", "Brad", "Lisa", "Jesse", "Greg", "Geoffry", "Heather" };
            Console.WriteLine("CLASS LIST");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine((i + 1) + ":" + names[i]);
            }
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("CLASS LIST");
            foreach (string name in names)
            {
                Console.WriteLine("-" + name);
            }
        }
    }
}
