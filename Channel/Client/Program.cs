using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.ServiceModel;
using System.Text;
using Channel.Entity;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a channel
            // NOTE host the service to IIS, and paste its url here
            EndpointAddress address = new EndpointAddress("http://localhost/Wcf_Channel/Service.svc");
            WSHttpBinding binding = new WSHttpBinding();
            ChannelFactory<ICalculator> factory = new ChannelFactory<ICalculator>(binding, address);
            ICalculator channel = factory.CreateChannel();

            // Call the Add service operation.
            double value1 = 100.00D;
            double value2 = 15.99D;
            double result = channel.Add(value1, value2);
            Console.WriteLine("Add({0},{1}) = {2}", value1, value2, result);

            // Call the Subtract service operation.
            value1 = 145.00D;
            value2 = 76.54D;
            result = channel.Subtract(value1, value2);
            Console.WriteLine("Subtract({0},{1}) = {2}", value1, value2, result);

            // Call the Multiply service operation.
            value1 = 9.00D;
            value2 = 81.25D;
            result = channel.Multiply(value1, value2);
            Console.WriteLine("Multiply({0},{1}) = {2}", value1, value2, result);

            // Call the Divide service operation.
            value1 = 22.00D;
            value2 = 7.00D;
            result = channel.Divide(value1, value2);
            Console.WriteLine("Divide({0},{1}) = {2}", value1, value2, result);

            Console.WriteLine();
            Console.WriteLine("Press <ENTER> to terminate client.");
            Console.ReadLine();

            //((IChannel)channel).Close();
        }
    }
}
