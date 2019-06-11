using System;
using DistantClient.DispatchingService;

namespace DistantClient
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DispatchingClient factory = new DispatchingClient("DispatchingService");
            IDispatching service = factory;
            try
            {

                MSG addParam = new MSG();
                addParam.AppToken = "tok";
                addParam.DataTable = new Object[] {4, 5};
                addParam.OpName = "add";
                MSG add = service.dispatch(addParam);
                //MSG sub = service.dispatch(new MSG("sub", "tok", new Object[] {4, 5}));
                //MSG operror = service.dispatch(new MSG("div", "tok", new Object[] {1, 2}));
                //MSG tok_error = service.dispatch(new MSG("add", "wrongtok", new Object[] {1, 2}));
                Console.WriteLine(add.DataTable[0]);
                //Console.WriteLine(sub.DataTable[0]);
                //Console.WriteLine(operror.DataTable[0]);
                //Console.WriteLine(tok_error.DataTable[0]);
                
            }
            catch
            {
                factory.Abort();
                throw;
            }
            factory.Close();
            
        }
    }
}