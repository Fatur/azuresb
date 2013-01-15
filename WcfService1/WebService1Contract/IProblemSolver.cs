using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace WebService1Contract
{
    [ServiceContract(Namespace = "urn:ps")]
    public interface IProblemSolver
    {
        [OperationContract]
        int AddNumbers(int a, int b);
        [OperationContract]
        string GetBigString();
    }

    public interface IProblemSolverChannel : IProblemSolver, IClientChannel { }
}
