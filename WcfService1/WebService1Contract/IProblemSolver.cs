using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WebService1Contract
{
    [ServiceContract(Namespace = "urn:ps")]
    public interface IProblemSolver
    {
        [OperationContract, WebGet]
        int AddNumbers(int a, int b);
        [OperationContract, WebGet]
        string GetBigString();
    }

    public interface IProblemSolverChannel : IProblemSolver, IClientChannel { }
}
