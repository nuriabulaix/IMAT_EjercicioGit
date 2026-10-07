namespace IMAT_GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"2 * 4 = {Multiply(2, 4)}");;
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
        static int Multiply(int x, int y)
        {
            return x * y;
        }
    }
}