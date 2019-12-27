using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StringOp;
using NUnit.Framework;
using NUnit;
using System.Threading.Tasks;

namespace StringTests
{
    [TestFixture]
    public class StringReversed
    {

        [Test]
        [TestCase("ab-cd", "dc-ba")]
        [TestCase("a-bC-dEf-ghIj", "j-Ih-gfE-dCba")]
        [TestCase("Test1ng-Leet=code-Q!", "Qedo1ct-eeLg=ntse-T!")]
        public void Test1(string input, string output)
        {

            ReversedString st = new ReversedString(input);
            string actual = st.ReversedIgnore();
            Assert.AreEqual(actual, output);
        }


        [Test]

        public void Should_Throw_Exception_When_EmptyString()
        {
            //Arrange
            string input = "";
            ReversedString st = new ReversedString(input);

            //Act
            //Assert

            Assert.Throws<NotImplementedException>(() => st.ReversedIgnore());
        }
    }
}
