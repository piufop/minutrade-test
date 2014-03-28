using Contracts;
using System.Collections.Generic;

namespace Data
{
    public class ClientData
    {
        public static void SaveClient(Client client)
        {
            // Atualiza os dados do cliente no BD.
            // Dependendo da quantidade de acessos e de dados trafegados, pode ser interessante implementar o padrão Batch Method.
        }
    }
}
