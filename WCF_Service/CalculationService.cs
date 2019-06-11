using System;
using WCF_DataContracts;

namespace WCF_Service
{
    public class CalculationService : WCF_Contracts.ICalculationService
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }
        
    }
}