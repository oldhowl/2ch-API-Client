using Wakaba2ChApiClient.Interfaces;

namespace Wakaba2ChApiClient
{
    public class Wakaba2ChApiClient : IWakaba2ChApiClient
    {
        public IWakaba2ChApi Client { get; }
        public IWakaba2ChApiMobile ClientMobile { get; }

        public Wakaba2ChApiClient(IWakaba2ChApi client, IWakaba2ChApiMobile clientMobile)
        {
            Client = client;
            ClientMobile = clientMobile;
        }
    }
}