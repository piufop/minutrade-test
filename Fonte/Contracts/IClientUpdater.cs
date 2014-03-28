using System.ServiceModel;

namespace Contracts
{
    [ServiceContract]
    public interface IClientUpdater
    {
        [OperationContract]
        void UpdateClient(Client client);
    }
}
