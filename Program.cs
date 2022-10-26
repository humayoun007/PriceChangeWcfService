using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FundScreenerWcfHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(PriceTicker));
            host.Open();
            Console.WriteLine($"Service started at {host.Description.Endpoints[0].Address}");
            Console.WriteLine("Press key to stop the service.");
            Console.ReadLine();
            host.Close();
        }
    }
}
