using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebService1Contract;
using System.ServiceModel;
using Microsoft.ServiceBus;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   var cf = new ChannelFactory<IProblemSolverChannel>(
       new NetTcpRelayBinding(),
       new EndpointAddress(ServiceBusEnvironment.CreateServiceUri("sb", "faturtest1", "solver")));

               cf.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior { TokenProvider = TokenProvider.CreateSharedSecretTokenProvider("owner", "cIdkZ0Fo6rM2AEADszEi81LL4ySCt/sqiP7qHr40W2A=") });

               using (var ch = cf.CreateChannel())
               {
                   Console.WriteLine(ch.AddNumbers(4, 5));
               }
           }
           * */
            var cf = new ChannelFactory<IProblemSolverChannel>("solver");
            using (var ch = cf.CreateChannel())
            {
                Console.WriteLine(ch.AddNumbers(4, 5));
                Console.WriteLine(ch.GetBigString());
                Console.ReadLine();
            }
        }

    }
}
