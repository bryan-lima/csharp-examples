namespace Classes.Methods
{
    public class Ref
    {
        static void Reverse(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Reverse()
        {
            int i = 1, j = 2;
            Reverse(ref i, ref j);
            System.Console.WriteLine($"{i} {j}");  // Write "2 1"
        }
        
    }
}