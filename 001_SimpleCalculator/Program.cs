namespace _001_SimpleCalculator
{
    public class Program
    {
        public class Calculator
        {
            public int Add(int a, int b) => a + b;

            public int Subtract(int a, int b) => a - b;

            public int Multiplication(int a, int b) => a * b;
            
            public int Division(int a, int b) => a / b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
