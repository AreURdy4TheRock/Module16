using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module16.Tests
{
    [TestFixture]
    public class Class1
    {
        [Test, Description("Тест сложения")]
        public void AdditionalMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Additional(1, 3) == 4);
        }

        [Test, Description("Тест вычитания")]
        public void SubtractionMustReturnCorrectValue() 
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(10, 4) == 6);
        }

        [Test, Description("Тест умножения")]
        public void MultiplicationMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Miltiplication(5, 5) == 25);
        }

        [Test, Description("Тест деления")]
        public void DivisionMustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Division(20, 4) == 5);
        }

        [Test, Description("Тест деления на ноль")]
        public void DivisionByZeroMustReturnException()
        {
            Calculator calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(10, 0));
        }
    }
}
