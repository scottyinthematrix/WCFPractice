using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using ScottyApps.WCFPractice.CalcService;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof (CalcService)))
            {
                host.Open();
                Console.WriteLine("Service is running...Press Enter to terminate it...");
                Console.ReadLine();
            }
        }

    }
}
