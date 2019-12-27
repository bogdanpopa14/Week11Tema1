using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoatLatin;
using GenericCalculator;
using System.Threading.Tasks;

namespace week11tema1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator<int> calc = new Calculator<int>();
            //int res = calc.Div(22, 10);
            GoatLatinConvertor conv = new GoatLatinConvertor("I speak Goat Latin");
            string outp= conv.ConvertToGoat();
        }
    }
}
