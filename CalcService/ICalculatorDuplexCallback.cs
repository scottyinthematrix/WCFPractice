using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace ScottyApps.WCFPractice.CalcService
{
    public interface ICalculatorDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void PrintResult(string s);
    }
}
