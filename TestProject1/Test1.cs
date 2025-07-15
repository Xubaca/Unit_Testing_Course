using _001_SimpleCalculator;
using System.Reflection.PortableExecutable;
using Calculator = _001_SimpleCalculator.Program.Calculator;
using FluentAssertions;

namespace TestProject1
{
    //Using the three A's Convention
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
            int? division = calc.Division(a: 10, b: 2);

            //Assert
            Assert.IsTrue(5 == division);
        }
        [TestMethod]
        public void TestAddWithMultipleAssertions_ExpectedToPass()
        {
            //Arrange
            Calculator calc = new Calculator();
            int first_number = 15,second_number = 10;
            int actual_number = 25;

            //Act
            int addition_result = calc.Add(first_number, second_number);

            //Multiple Assertions
            Assert.IsTrue(actual_number == addition_result);
            Assert.AreEqual(actual_number, addition_result);   
        }
        [TestMethod]
        public void MS_Challenge_DivisionToFail()
        {
            //Arrange
            Calculator calc = new Calculator();
            int first_number = 10,second_number =2;

            //Act
            int? actual = calc.Division(first_number, second_number);

            //Assert
            Assert.IsTrue(actual == 5);

        }
        /// <summary>
        /// The Correct behaviour here would be to return null when divided by zero, but because said behaviour is not implemented its meant to fail,
        /// ahead in the course i was asked to correct this function
        /// </summary>
        [TestMethod]
        public void MS_Challenge_DividedByZero()
        {
            //Arrange
            Calculator calc = new Calculator();
            int first_number = 10, second_number = 0;

            //Act
            int? actual_number = calc.Division(first_number, second_number);

            //its never getting here
            //Assert
            Assert.IsNull(actual_number);


        }

    }

    //fluent assertions are way more readable

    [TestClass]
    public sealed class FA_CalculatorTester
    {
        [TestMethod]
        public void FA_TestAddition()
        {
            //Arrange
            Calculator calc = new();
            int first = 10, second = 1, actual = 11;
            

            //Act
            int result = calc.Add(a: first, b: second);

            //Assert
            result.Should().Be(actual);


        }
    }
}
