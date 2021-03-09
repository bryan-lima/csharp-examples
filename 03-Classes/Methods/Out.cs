namespace Classes.Methods
{
    public class Out
    {
        static void Divide(int x, int y, out int result, out int rest)
        {
            result = x / y;
            rest = x % y;
        }

        public static void Divide()
        {
            Divide(10, 3, out int result, out int rest);
            System.Console.WriteLine("{0} {1}", result, rest);  // Write "3 1"
        }
    }
}