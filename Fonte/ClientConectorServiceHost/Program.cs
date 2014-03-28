using Services;
using System;
using System.ServiceModel;

namespace ClientConectorServiceHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Integration Service";
            Console.WriteLine("Inicializando...");

            using (ServiceHost host = new ServiceHost(typeof(ClientUpdater), new Uri[] {}))
            {
                host.Open();
                Console.WriteLine("Pronto.");
                Console.WriteLine("Esperando solicitações...");
                Console.ReadLine();
            }
        }
    }
}
