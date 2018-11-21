using Server.Contracts;
using Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(nameof(LineProcessing), new Uri("http://local//"));

            ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
            behavior.HttpsGetEnabled = true;
            serviceHost.Description.Behaviors.Add(behavior);
            serviceHost.AddServiceEndpoint(typeof(ILineProcessing), new WSHttpBinding(), "SearchSubstring");

            serviceHost.Open();
            Console.WriteLine("To close the server, press ( Escape )");

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("Server was the closed");
                    break;
                }
            }
        }
    }
}