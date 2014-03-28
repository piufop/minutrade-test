using PartnerClientApplication.ClientUpdater;
using System;
using System.Configuration;

namespace PartnerClientApplication
{
    public class Program
    {
        private static string BindingConfiguration { get; set; }

        static void Main(string[] args)
        {
            LoadConfiguration();
            Initialize();

            // Cria uma instância do cliente e atualiza os dados.
            var cliente = CreateRandomClientData();
            UpdateClient(cliente);

            Console.ReadKey();
        }

        private static void LoadConfiguration()
        {
            BindingConfiguration = ConfigurationManager.AppSettings.Get("BindingConfiguration");
        }

        private static void Initialize()
        {
            Console.Title = "Partner Client Application";
        }

        private static void UpdateClient(Client cliente)
        {
            try
            {
                // Solicita ao serviço de atualização do cliente para atualizar os dados.
                using (ClientUpdaterClient clientUpdater = new ClientUpdaterClient(BindingConfiguration))
                {
                    clientUpdater.UpdateClient(cliente);
                    clientUpdater.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Não foi possível atualizar os dados do cliente. \r\n {0}", ex.Message));
            }
        }

        private static Client CreateRandomClientData()
        {
            var random = new Random();
            return new Client() { DataNascimento = DateTime.Now, TelefoneCelular = random.Next(82110000, 99999999).ToString() };
        }
    }
}
