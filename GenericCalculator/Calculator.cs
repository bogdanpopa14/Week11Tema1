using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCalculator
{
    public class Calculator<T> where T : struct, IComparable<T>, IConvertible
    {
        public T Add(T a,T b)
        {
            return (dynamic)a + b;
        }

        public T Sub(T a,T b)
        {
            return (dynamic)a - b;
        }

        public T Mul(T a, T b)
        {
            return (dynamic)a * b;
        }

        public T Div(T a, T b)
        {
            if (b.Equals(default(T)))
            {
                throw new NotImplementedException();
            }
            return (dynamic)a / (dynamic)b;
        }

    }
}
