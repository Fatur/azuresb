using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebService1Contract;
using System.ServiceModel.Web;

namespace Service
{
    public class ProblemSolver : IProblemSolver
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }


        public string GetBigString()
        {
            WebOperationContext.Current.OutgoingResponse.ContentType = "application/text";
            return "This guide will show you how to use the Service Bus relay service. The samples are written in C# and use the Windows Communication Foundation API with extensions contained in the Service Bus assembly that is part of the .NET libraries for Windows Azure. For more information on the Service Bus relay, see the Next Steps section." 
                + "The Service Bus Relay service enables you to build hybrid applications that run in both a Windows Azure datacenter and your own on-premises enterprise environment. The Service Bus relay facilitates this by enabling you to securely expose Windows Communication Foundation (WCF) services that reside within a corporate enterprise network to the public cloud, without having to open up a firewall connection or requiring intrusive changes to a corporate network infrastructure." 
                + "The Service Bus relay allows you to host WCF services within your existing enterprise environment. You can then delegate listening for incoming sessions and requests to these WCF services to the Service Bus running within Windows Azure. This enables you to expose these services to application code running in Windows Azure, or to mobile workers or extranet partner environments. The Service Bus allows you to securely control who can access these services at a fine-grain level. It provides a powerful and secure way to expose application functionality and data from your existing enterprise solutions and take advantage of it from the cloud. This guide demonstrates how to use the Service Bus relay to create a WCF web service, exposed using a TCP channel binding, that implements a secured conversation between two parties."
                + "The Service Bus NuGet package is the easiest way to get the Service Bus API and to configure your application with all of the Service Bus dependencies. The NuGet Visual Studio extension makes it easy to install and update libraries and tools in Visual Studio and Visual Web Developer. The Service Bus NuGet package is the easiest way to get the Service Bus API and to configure your application with all of the Service Bus dependencies."
                + "To expose an existing WCF SOAP web service for external consumption, you must make changes to the service bindings and addresses. This may require changes to your configuration file or it could require code changes, depending on how you have set up and configured your WCF services. Note that WCF allows you to have multiple network endpoints over the same service, so you can retain the existing internal endpoints while adding Service Bus endpoints for external access at the same time."
                + "In this task, you will build a simple WCF service and add a Service Bus listener to it. This exercise assumes some familiarity with Visual Studio 2012, and therefore does not walk through all the details of creating a project. Instead, it focuses on the code."
                + "The contract defines a single operation, AddNumbers, that adds two numbers and returns the result. The IProblemSolverChannel interface enables the client to more easily manage the proxy lifetime. Creating such an interface is considered a best practice. It's a good idea to put this contract definition into a separate file so that you can reference that file from both your  and projects, but you can also copy the code into both projects:"
                + "The endpoint definitions move into the App.config file. The following snippet, which is the same as the code listed above, should appear directly beneath the system.serviceModel element. Here, as before, you must replace the placeholders with your Service Bus service namespace and key";
        }
    }
}
