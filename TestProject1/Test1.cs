using _001_SimpleCalculator;
using System.Reflection.PortableExecutable;
using Calculator = _001_SimpleCalculator.Program.Calculator;

namespace TestProject1
{
    [TestClass]
    public sealed class CalculatorTester
    {
        [TestMethod]
        public void TestAdd()
        {
            Calculator calc = new Calculator();

            Assert.IsTrue(10 == calc.Add(a: 10, b: 0));
            Assert.IsTrue(5 == calc.Add(-3, 8));
            Assert.IsFalse(11 != 11);
        }
        [TestMethod]
        public void TestSubtract()
        {
            //Arrange
            Calculator calc = new Calculator();

            //Act
            int subtraction = calc.Subtract(a: 15, b: 12);

            //Assert
            Assert.AreEqual(3, subtraction);
            
        }
        [TestMethod]
        public void TestMultilication()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int multiplication = calc.Multiplication(15, 3);

            //Assert
            Assert.IsTrue(45 == multiplication);
        }
        [TestMethod]
        public void TestDivision()
        {
            //Arrange
            Calculator calc = new();

            //Act
            int division = calc.Division(a: 10, b: 2);

            //Assert
            Assert.IsTrue(5 == division);
        }
    }
}
