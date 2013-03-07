using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestOneWay();
            TestEcho();

            Console.ReadLine();
        }

        static void TestOneWay()
        {
            EchoClient echo = new EchoClient();
            Console.WriteLine("start to call SayHello...{0}", DateTime.Now);
            echo.SayHello("scotty");
            Console.WriteLine("end of calling SayHello...{0}", DateTime.Now);
        }

        static void TestEcho()
        {
            EchoClient echo = new EchoClient();
            var result = echo.Echo("welcome to wcf!");
            Console.WriteLine(result);
        }
    }
}
