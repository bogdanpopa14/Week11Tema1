using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GoatLatin;
using System.Threading.Tasks;

namespace GoatLatinTests
{
    [TestFixture]
    public class GoatLatinConvertorTests
    {

        [Test]
        [TestCase("I speak Goat Latin", "Imaa peaksmaaa oatGmaaaa atinLmaaaaa")]
        [TestCase("The quick brown fox jumped over the lazy dog", "heTmaa uickqmaaa rownbmaaaa oxfmaaaaa umpedjmaaaaaa overmaaaaaaa hetmaaaaaaaa azylmaaaaaaaaa ogdmaaaaaaaaaa")]
        public void TestConvertor(string input,string output)
        {
            GoatLatinConvertor conv = new GoatLatinConvertor(input);
            string actual = conv.ConvertToGoat();
            Assert.AreEqual(actual, output);
        }
    }
}
