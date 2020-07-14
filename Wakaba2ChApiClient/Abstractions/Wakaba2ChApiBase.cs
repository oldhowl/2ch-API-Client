using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wakaba2ChApiClient.Exceptions;

namespace Wakaba2ChApiClient.Abstractions
{
    public abstract class Wakaba2ChApiBase
    {
        private readonly HttpClient _httpClient;

        protected Wakaba2ChApiBase(HttpClientHandler httpClientHandler = null)
        {
            _httpClient = new HttpClient(httpClientHandler ?? new HttpClientHandler());
        }

        protected async Task<T> Get<T>(string url)
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