using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient svc = new CalculatorClient();

            Console.WriteLine(svc.Add(99.3, 29.8));


            svc.Close();
        }
    }
}
