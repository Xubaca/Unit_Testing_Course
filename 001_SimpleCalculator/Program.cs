namespace _001_SimpleCalculator
{
    public class Program
    {
        public class Calculator
        {
            public int Add(int a, int b) => a + b;

            public int Subtract(int a, int b) => a - b;

            public int Multiplication(int a, int b) => a * b;

            public int? Division(int a, int b)
            {
                if (b != 0) return a / b;
                else
                {
                    Console.WriteLine("Hello good sir, please dont try to divid by zero in the future!\nBest regards.");
                    return null;
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
