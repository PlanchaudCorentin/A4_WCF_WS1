using System.ServiceModel;
using WCF_DataContracts;

namespace WCF_Contracts
{
    
    [ServiceContract]
    public interface IDispatching
    {
        [OperationContract]
        MSG dispatch(MSG msg);

    }
}