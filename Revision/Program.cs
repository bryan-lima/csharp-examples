using System;

namespace Revision
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[5];
            var studentIndex = 0;

            string userOption = GetUserOption();

            while (userOption.ToUpper() != "X")
            {
                switch (userOption)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        Student student = new Student();
                        student.Name = Console.ReadLine();

                        Console.WriteLine("Informe a nota do aluno:");
                        if (decimal.TryParse(Console.ReadLine(), out decimal note))
                        {
                            student.Note = note;
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal!");
                        }

                        students[studentIndex] = student;
                        studentIndex++;

                        break;
                    case "2":
                        foreach (var s in students)
                        {
                            if (!string.IsNullOrEmpty(s.Name))
                            {
                                Console.WriteLine($"ALUNO: {s.Name} - NOTA: {s.Note}");
                            }
                        }

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
            Console.WriteLine("---------------------------");
            Console.WriteLine(" Informe a opção desejada: ");
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine("---------------------------");
            Console.WriteLine();

            string userOption = Console.ReadLine();
            Console.WriteLine();
            return userOption;
        }
    }
}
