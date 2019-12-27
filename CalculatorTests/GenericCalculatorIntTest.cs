using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GenericCalculator;
using System.Threading.Tasks;

namespace GenericCalculatorTests
{
    [TestFixture]
    public class GenericCalculatorIntTest
    {

        [Test]
        [TestCase(1,2,3)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 2)]
        [TestCase(10, 22, 32)]
        public void Test_Int_Add(int a,int b,int output)
        {
            Calculator<int> cal = new Calculator<int>();
            int actual = cal.Add(a, b);
            Assert.AreEqual(actual, output);
        }

        [Test]
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(0, 2, -2)]
        [TestCase(10, 22, -12)]
        public void Test_Int_Sub(int a, int b, int output)
        {
            Calculator<int> cal = new Calculator<int>();
            int actual = cal.Sub(a, b);
            Assert.AreEqual(actual, output);
        }



        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 0)]
        [TestCase(10, 22, 220)]
        public void Test_Int_Mul(int a, int b, int output)
        {
            Calculator<int> cal = new Calculator<int>();
            int actual = cal.Mul(a, b);
            Assert.AreEqual(actual, output);
        }


        [Test]
        [TestCase(1, 2, 0)]
        [TestCase(2, 2, 1)]
        [TestCase(5, 2, 2)]
        [TestCase(22, 10, 2)]
        public void Test_Int_Div(int a, int b, int output)
        {
            Calculator<int> cal = new Calculator<int>();
            int actual = cal.Div(a, b);
            Assert.AreEqual(actual, output);
        }

        [Test]

        public void Should_Throw_Exception_When_DivideBy0()
        {
            //Arrange
            int a = 5;
            int b = 0;
            Calculator<int> calc = new Calculator<int>();

            //Act
            //Assert

            Assert.Throws<NotImplementedException>(() => calc.Div(a,b));
        }
    }


    [TestFixture]
    public class GenericCalculatorDoubleTest
    {

        [Test]
        [TestCase(1, 2, 3)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 2)]
        [TestCase(10, 22, 32)]
        public void Test_Double_Add(double a, double b, double output)
        {
            Calculator<double> cal = new Calculator<double>();
            double actual = cal.Add(a, b);
            Assert.AreEqual(actual, output);
        }

        [Test]
        [TestCase(1, 2, -1)]
        [TestCase(2, 2, 0)]
        [TestCase(0, 2, -2)]
        [TestCase(10, 22, -12)]
        public void Test_Double_Sub(double a, double b, double output)
        {
            Calculator<double> cal = new Calculator<double>();
            double actual = cal.Sub(a, b);
            Assert.AreEqual(actual, output);
        }



        [Test]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 4)]
        [TestCase(0, 2, 0)]
        [TestCase(10, 22, 220)]
        public void Test_Double_Mul(double a, double b, double output)
        {
            Calculator<double> cal = new Calculator<double>();
            double actual = cal.Mul(a, b);
            Assert.AreEqual(actual, output);
        }


        [Test]
        [TestCase(1, 2, 0.5)]
        [TestCase(2, 2, 1)]
        [TestCase(5, 2, 2.5)]
        [TestCase(22, 10, 2.2)]
        public void Test_Div_Div(double a, double b, double output)
        {
            Calculator<double> cal = new Calculator<double>();
            double actual = cal.Div(a, b);
            Assert.AreEqual(actual, output);
        }

        [Test]

        public void Should_Throw_Exception_When_DivideBy0()
        {
            //Arrange
            int a = 5;
            int b = 0;
            Calculator<double> calc = new Calculator<double>();

            //Act
            //Assert

            Assert.Throws<NotImplementedException>(() => calc.Div(a, b));
        }
    }

}
