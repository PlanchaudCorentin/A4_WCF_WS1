using System;
using DistantClient2.DispatchingService;

namespace DistantClient2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MSG msg = new MSG();
            msg.AppToken = "tok";
            msg.DataTable = new Object[] {390, 84};
            msg.OpName = "sub";
            Console.WriteLine(new DispatchingService.DispatchingClient().dispatch(msg).DataTable[0]);
        }
    }
}