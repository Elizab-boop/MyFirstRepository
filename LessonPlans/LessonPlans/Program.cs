using System;
using System.Collections.Generic;

namespace LessonPlans
{
    class Program
    {
        private static int waitTime = 50;
        static void Main(string[] args)
        {
            Person beth = new Elizabeth();

            Console.WriteLine((beth as Elizabeth).SummarizeElizabeth());
        }

        private static void MenuPrograsm()
        {
            bool shouldRun = true;

            while (shouldRun)
            {
                WriteSlowMessage("Menu Example");
                WriteSlowMessage("1. Run program");
                WriteSlowMessage("2. End program");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        WriteSlowMessage("Running Program");
                        break;
                    case "2":
                        WriteSlowMessage("Ending Program");
                        shouldRun = false;
                        break;
                    default:
                        WriteSlowMessage("This is an invalid choice!");
                        break;
                }

                while (input != "2")
                {
                    SecondMenu();

                    WriteSlowMessage("Do you want to continue making choices");
                    WriteSlowMessage("1. Yes");
                    WriteSlowMessage("2. No");

                    input = Console.ReadLine();
                }
            }
        }

        private static void SecondMenu()
        {
            WriteSlowMessage("1. Perform an action and then move to the next menu.");
            WriteSlowMessage("2. Choice 2");
            WriteSlowMessage("3. Choice 3");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    WriteSlowMessage("Moving to next area");
                    SubMenu1();
                    break;
                case "2":
                    SubMenu2();
                    break;
                case "3":
                    SubMenu3();
                    break;
                default:
                    WriteSlowMessage("This is an invalid choice!");
                    break;
            }
        }
        private static void PerformAction()
        {
            WriteSlowMessage("Choose an action.");
            Console.WriteLine();
            WriteSlowMessage("1. Picking item");
            WriteSlowMessage("2. Staging item");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    WriteSlowMessage("Picking!");
                    break;
                case "2":
                    WriteSlowMessage("Staging!");
                    break;
                default:
                    WriteSlowMessage("This is an invalid choice!");
                    break;
            }
        }

        private static void SubMenu1()
        {
            WriteSlowMessage("SubMenu1 Example");
            WriteSlowMessage("1. Perform Action");
            WriteSlowMessage("2. Do Nothing");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    PerformAction();                   
                    break;
                case "2":
                    WriteSlowMessage("Okay, you chose 2!");
                    break;
                default:
                    WriteSlowMessage("This is an invalid choice!");
                    break;
            }
        }
        private static string Choice()
        {
            WriteSlowMessage("Do you want to continue making choices");
            WriteSlowMessage("1. Yes");
            WriteSlowMessage("2. No");

            string input = Console.ReadLine();

            return input;
        }

        private static void SubMenu2()
        {
            //throw new NotImplementedException();
        }
        private static void SubMenu3()
        {
            //throw new NotImplementedException();
        }

        private static void WriteSlowMessage(string message)
        {
            foreach(char c in message)
            {
                if (Console.KeyAvailable)
                    waitTime = 0;

                Console.Write(c);

                if(waitTime != 0)
                    System.Threading.Thread.Sleep(waitTime);
            }
            Console.WriteLine();
        }

        private static int Recursion(int value)
        {
            value++;
            Console.WriteLine($"Current value of integer is {value}");
            System.Threading.Thread.Sleep(200);


                return Recursion(value);
        }

        private static void Menu()
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

                Console.ReadKey();
            }
        }

        private static void FuckThis()
        {
            int[] values = new int[] { 2, 4, 3 };

            SquareValues(values);

            //foreach (int value in values)
            //{
            //    Console.WriteLine(value);
            //}

            int changeMe = 1;

            ChangeReferenceValue(ref changeMe);

            Console.WriteLine();
            Console.WriteLine(changeMe);

            int value = GetNumber();
        }

        static int GetNumber()
        {
            return (int)1.0;
        }

        static int GetAnotherNumber()
        {
            return 7;
        }

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
            for(int i = 0; i < values.Length; i++)
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
    }
}
