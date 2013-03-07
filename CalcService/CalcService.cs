using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ScottyApps.WCFPractice.CalcService
{
    public class CalcService : ICalcService
    {
        public Complex Add(Complex x, Complex y)
        {
            return new Complex(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }

        public Complex Subtract(Complex x, Complex y)
        {
            return new Complex(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        public Complex Multiply(Complex x, Complex y)
        {
            return new Complex(x.Real * y.Real - x.Imaginary * y.Imaginary, x.Real * y.Imaginary + x.Imaginary * y.Real);
        }

        public Complex Devide(Complex x, Complex y)
        {
            throw new NotImplementedException("too complex to remember...");
        }
    }
}
