using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using ScottyApps.WCFPractice.CalcService;

namespace ConsoleClient
{
    class CalculatorCallBack : IEchoCallback
    {
        public void PrintResult(string rsl)
        {
            Console.WriteLine("server told me the result is: {0}", rsl);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TestOneWay();
            //TestEcho();
            //TestCallback();
            TestRefOut();

            Console.ReadLine();
        }

        static void TestOneWay()
        {
            // NOTE it's really good to test the IsOneWay functionality, it works, as expected!
            InstanceContext ctx = new InstanceContext(new CalculatorCallBack());
            EchoClient echo = new EchoClient(ctx);
            Console.WriteLine("start to call SayHello...{0}", DateTime.Now);
            echo.SayHello("scotty");
            Console.WriteLine("end of calling SayHello...{0}", DateTime.Now);
        }

        static void TestEcho()
        {
            InstanceContext ctx = new InstanceContext(new CalculatorCallBack());
            EchoClient echo = new EchoClient(ctx);
            var result = echo.Echo("welcome to wcf!");
            Console.WriteLine(result);
        }

        static void TestCallback()
        {
            InstanceContext ctx = new InstanceContext(new CalculatorCallBack());
            EchoClient client = new EchoClient(ctx);
            client.SayHello("scotty & juicy");
        }

        static void TestRefOut()
        {
            CalcServiceClient client = new CalcServiceClient();
            Complex x = new Complex { Real = 9.2, Imaginary = 8.4 };
            Complex y = new Complex { Real = 6.4, Imaginary = 5.8 };
            Complex rsl;

            var s = client.Add(ref x, ref y, out rsl);
            Console.WriteLine("adding {0} with {1}, and we get {2}, return value: {3}", x, y, rsl, s);
        }
    }
}
