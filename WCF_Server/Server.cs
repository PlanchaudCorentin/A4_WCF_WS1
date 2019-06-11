using System;
using System.ServiceModel;

namespace WCF_Server
{
    public class Server
    {
        static void Main(string[] argd)
        {
            ServiceHost host = new ServiceHost(typeof(WCF_Service.DispatchingService));
            Console.WriteLine("listening on http://locahost:1997/WS");
            host.Open();
            Console.ReadLine();
            host.Close();
        }
    }
}