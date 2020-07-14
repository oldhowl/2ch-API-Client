using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Wakaba2ChApiClient.Exceptions;

namespace Wakaba2ChApiClient.Abstractions
{
    public abstract class Wakaba2ChApiBase
    {
        private HttpClientHandler _httpClientHandler;

        protected Wakaba2ChApiBase(HttpClientHandler httpClientHandler = null)
        {
            _httpClientHandler = httpClientHandler;
        }

        protected async Task<T> Get<T>(string url)
        {
            using (var httpClient = new HttpClient(_httpClientHandler, false))
            {
                var responseMessage =
                    await httpClient.GetAsync(url);

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