using System;
using ProgramStructure.Classes;

namespace ProgramStructure {
    class Program {
        static void Main() {
            var stack = new Stack();

            stack.StackUp(1);
            stack.StackUp(10);
            stack.StackUp(100);

            Console.WriteLine(stack.Unstack());
            Console.WriteLine(stack.Unstack());
            Console.WriteLine(stack.Unstack());
            Console.WriteLine(stack.Unstack());
        }
    }
}
