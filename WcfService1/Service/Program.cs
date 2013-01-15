using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WebService1Contract;
using Microsoft.ServiceBus;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(ProblemSolver));

           /* sh.AddServiceEndpoint(
               typeof(IProblemSolver), new NetTcpBinding(),
               "net.tcp://localhost:9358/solver");

            sh.AddServiceEndpoint(
               typeof(IProblemSolver), new NetTcpRelayBinding(),
               ServiceBusEnvironment.CreateServiceUri("sb", "faturtest1", "solver"))
                .Behaviors.Add(new TransportClientEndpointBehavior
                {
                    TokenProvider = TokenProvider.CreateSharedSecretTokenProvider("owner", "cIdkZ0Fo6rM2AEADszEi81LL4ySCt/sqiP7qHr40W2A=")
                });
            */
            sh.Open();

            Console.WriteLine("Press ENTER to close");
            Console.ReadLine();

            sh.Close();
        }
    }
}
