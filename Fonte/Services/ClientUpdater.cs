using Contracts;
using Data;
using System.Threading;

namespace Services
{
    public class ClientUpdater : IClientUpdater
    {
        /// <summary>
        /// Persiste os dados do cliente no banco de dados.
        /// </summary>
        public void UpdateClient(Client client)
        {
            // Persistir as alterações no BD.
            ClientData.SaveClient(client);
        }
    }
}
