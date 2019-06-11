using System;
using System.ServiceModel;
using WCF_DataContracts;

namespace WCF_Contracts

{
    [ServiceContract]
    public interface ICalculationService
    {
        [OperationContract]
        int add(int a, int b);
        [OperationContract]
        int sub(int a, int b);
        
    }
}