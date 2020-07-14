using Wakaba2ChApiClient.Interfaces;

namespace Wakaba2ChApiClient
{
    /// <summary>
    /// Полное описание API
    /// https://2ch.hk/api/index.html
    /// </summary>
    public interface IWakaba2ChApiClient
    {
        /// <summary>
        /// API общего назначения
        /// </summary>
        IWakaba2ChApi Client { get; }

        /// <summary>
        /// Мобильное API
        /// </summary>
        IWakaba2ChApiMobile ClientMobile { get; }
    }
}