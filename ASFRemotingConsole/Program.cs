using ASFRemotingCore;
using Microsoft.ServiceFabric.Services.Remoting.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASFRemotingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            while (!Console.KeyAvailable)
            {
                var testService = ServiceProxy.Create<IASFRemotingTest>(new Uri("fabric:/MyFirstFabric/ASFRemotingTest"));
                Console.WriteLine(testService.HighFive().Result);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
