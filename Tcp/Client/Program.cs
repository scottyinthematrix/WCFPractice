using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tcp.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient svc = new CalculatorClient();

            Console.WriteLine(svc.Divide(99.456,23.56));
        }
    }
}
