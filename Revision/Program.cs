using System;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        // TODO: Add student
                        Console.WriteLine($"Você digitou a opção {userOption}");
                        break;
                    case "2":
                        // TODO: List students
                        Console.WriteLine($"Você digitou a opção {userOption}");
                        break;
                    case "3":
                        // TODO: Calculate overall average
                        Console.WriteLine($"Você digitou a opção {userOption}");
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                userOption = GetUserOption();
            }
        }

        private static string GetUserOption()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string userOption = Console.ReadLine();
            return userOption;
        }
    }
}
