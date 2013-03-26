using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ScottyApps.WCFPractice.CalcService
{
    [ServiceContract(SessionMode = SessionMode.Required, CallbackContract = typeof(ICalculatorDuplexCallback))]
    interface IEcho
    {
        [OperationContract]
        string Echo(string msg);
        [OperationContract(IsOneWay = true)]
        void SayHello(string name);
    }
}
