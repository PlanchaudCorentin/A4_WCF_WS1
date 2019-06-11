using System;
using System.ServiceModel;
using WCF_Contracts;
using WCF_DataContracts;

namespace WCF_Client
{
    internal class Program
    {
        
        
        public static void Main(string[] args)
        {
            ChannelFactory<IDispatching> factory = 
                new ChannelFactory<IDispatching>("DispatchingService");
            IDispatching channel = factory.CreateChannel();
            try
            {
                MSG add = channel.dispatch(new MSG("add", "tok", new Object[] {1, 2}));
                MSG sub = channel.dispatch(new MSG("sub", "tok", new Object[] {4, 5}));
                MSG operror = channel.dispatch(new MSG("div", "tok", new Object[] {1, 2}));
                MSG tok_error = channel.dispatch(new MSG("add", "wrongtok", new Object[] {1, 2}));
                Console.WriteLine(add.DataTable[0]);
                Console.WriteLine(sub.DataTable[0]);
                Console.WriteLine(operror.DataTable[0]);
                Console.WriteLine(tok_error.DataTable[0]);
                
            }
            catch
            {
                factory.Abort();
                throw;
            }
            if (factory.State == CommunicationState.Opened)
            {
                factory.Close();
            }
            
        }
    }
}