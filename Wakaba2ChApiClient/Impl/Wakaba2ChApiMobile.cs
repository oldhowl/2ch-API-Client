using System.Net.Http;
using System.Threading.Tasks;
using Wakaba2ChApiClient.Abstractions;
using Wakaba2ChApiClient.Interfaces;
using Wakaba2ChApiClient.Models.Mobile;

namespace Wakaba2ChApiClient.Impl
{
    public class Wakaba2ChApiMobile : Wakaba2ChApiBase, IWakaba2ChApiMobile
    {
        public Wakaba2ChApiMobile(HttpClientHandler httpClientHandler = null) : base(httpClientHandler)
        {
        }


        public Task<MobileThreadOptions> GetThreadOptions() =>
            Get<MobileThreadOptions>(Wakaba2ChApiEndpointBuilder.ThreadOptionsEndpoint().AbsoluteUri);
    }
}