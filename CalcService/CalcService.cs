using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace ScottyApps.WCFPractice.CalcService
{
    public class CalcService : ICalcService, IEcho
    {
        #region calculation operations
        public string Add(ref Complex x, ref Complex y, out Complex rsl)
        {
            rsl = new Complex(x.Real + y.Real, x.Imaginary + y.Imaginary);
            return rsl.ToString();
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
            // TODO ((ac + bd) / (c2 + d2)) + ((bc - ad) / (c2 + d2)i
            throw new NotImplementedException("too complex to remember...");
        }
        #endregion

        #region Echo operations

        public string Echo(string msg)
        {
            Console.WriteLine("got msg: {0}", msg);
            return string.Format("echo back: {0}", msg);
        }

        public void SayHello(string name)
        {
            // NOTE this is to test the OneWay communication
            Console.WriteLine("start to sleep: {0}", DateTime.Now);
            Thread.Sleep(10000);
            Console.WriteLine("back from sleeping: {0}", DateTime.Now);
            Console.WriteLine("the guy {0} just said hello.", name);
            Console.WriteLine("let's see what would the client do now.");
            Callback.PrintResult("server is done.");
        }

        #endregion

        ICalculatorDuplexCallback Callback
        {
            get
            {
                return OperationContext.Current.GetCallbackChannel<ICalculatorDuplexCallback>();
            }
        }
    }
}
