using System;
using WCF_DataContracts;

namespace WCF_Service
{
    public class DispatchingService: WCF_Contracts.IDispatching
    {
        CalculationService _service = new CalculationService();
        
        public MSG dispatch(MSG msg)
        {
            if (msg.AppToken == "tok")
            {
                if (msg.OpName == "add")
                {
                    return new MSG("add", "tok", new Object[]{_service
                        .add((int) msg.DataTable[0], (int) msg.DataTable[1])});
                }
                if (msg.OpName == "sub")
                {
                    return new MSG("sub", "tok", new Object[]{_service
                        .sub((int) msg.DataTable[0], (int) msg.DataTable[1])});
                }
                return new MSG(msg.OpName, "tok", 
                        new Object[]{"this operation is not implemented"});
                
            }
            return new MSG(msg.OpName, msg.AppToken, 
                new Object[]{"wrong token"});
        }
    }
}