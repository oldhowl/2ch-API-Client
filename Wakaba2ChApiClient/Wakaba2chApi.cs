using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wakaba2ChApiClient.Exceptions;
using Wakaba2ChApiClient.Models;

namespace Wakaba2ChApiClient
{
    public class Wakaba2ChApi : IWakaba2ChApi

    {
        private HttpClient _httpClient;

        public Wakaba2ChApi(HttpClientHandler httpClientHandler = null)
        {
            _httpClient = new HttpClient(httpClientHandler ?? new HttpClientHandler());
        }


        public Task<AllThreads> GetAllThreadsFromBoard(string board = "b")
        {
            return Get<AllThreads>(Wakaba2ChApiEndpointBuilder.LiteThreadsEndpoint(board).AbsoluteUri);
        }

        public Task<LiteAllThreadsFromBoard> GetLiteAllThreadsFromBoard(string board = "b")
        {
            return Get<LiteAllThreadsFromBoard>(Wakaba2ChApiEndpointBuilder.LiteThreadsEndpoint(board).AbsoluteUri);
        }

        private async Task<T> Get<T>(string url)
        {
            using (_httpClient)
            {
                var responseMessage =
                    await _httpClient.GetAsync(url);
                var body = await responseMessage.Content.ReadAsStringAsync();
                if (!responseMessage.IsSuccessStatusCode)
                    throw new Wakaba2ChHttpException(responseMessage.StatusCode, body);

                try
                {
                    return JsonConvert.DeserializeObject<T>(body);
                }
                catch (Exception e)
                {
                    throw new Wakaba2ChSerializationException(e.Message);
                }
            }
        }
    }
}