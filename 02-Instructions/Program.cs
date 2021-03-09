using System;

namespace Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // Declarações
        static void Statements()
        {
            int a;
            int b = 2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d); // 10
        }

        static void InstructionIf(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No arguments");
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("An argument");
            }
            else
            {
                Console.WriteLine($"{args.Length} arguments");
            }
        }

        static void InstructionSwitch(string[] args)
        {
            int numberOfArguments = args.Length;

            switch (numberOfArguments)
            {
                case 0:
                    Console.WriteLine("No arguments");
                    break;
                case 1:
                    Console.WriteLine("An argument");
                    break;
                default:
                    Console.WriteLine($"{args.Length} arguments");
                    break;
            }
        }

        static void InstructionWhile(string[] args)
        {
            int i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstructionDo(string[] args)
        {
            string text;

            do
            {
                text = Console.ReadLine();
                Console.WriteLine(text);
            } while (!string.IsNullOrEmpty(text));
        }

        static void InstructionFor(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstructionForEach(string[] args)
        {
            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
        }

        static void InstructionBreak(string[] args)
        {
            while (true)
            {
                string s = Console.ReadLine();

                if (string.IsNullOrEmpty(s))
                    break;

                Console.WriteLine(s);
            }
        }

        static void InstructionContinue(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                if (args[i].StartsWith("/"))
                    continue;

                Console.WriteLine(args[i]);
            }
        }

        static void InstructionReturn()
        {
            int Sum(int a, int b)
            {
                return a + b;
            }

            Console.WriteLine(Sum(1, 2));
            Console.WriteLine(Sum(3, 4));
            Console.WriteLine(Sum(5, 6));
            return;
        }

        static void InstructionTryCatchFinallyThrow(string[] args)
        {
            double Divide(double x, double y)
            {
                if (y == 0)
                    throw new DivideByZeroException();

                return x / y;
            }

            try
            {
                if (args.Length != 2)
                {
                    throw new InvalidOperationException("Enter 2 numbers");
                }

                double x = double.Parse(args[0]);
                double y = double.Parse(args[1]);
                Console.WriteLine(Divide(x, y));
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Generic error: {e.Message}");
            }
            finally
            {
                Console.WriteLine("See you soon!");
            }
        }

        static void InstructionUsing(string[] args)
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("text.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }
        }
    }
}
