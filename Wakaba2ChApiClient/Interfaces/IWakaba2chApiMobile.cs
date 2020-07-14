using System.Threading.Tasks;
using Wakaba2ChApiClient.Models.Mobile;

namespace Wakaba2ChApiClient.Interfaces
{
    public interface IWakaba2ChApiMobile
    {
        Task<MobileThreadOptions> GetThreadOptions();
    }
}