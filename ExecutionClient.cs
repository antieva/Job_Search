using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace myApp
{
    public class ExecutionClient 
    {
        private readonly HttpClient _client = new HttpClient();
        public async Task<T> StartExecution<T>() 
        {
            var link = Environment.GetEnvironmentVariable("START_EXECUTION");
            HttpResponseMessage response = await _client.PostAsync(link, null).ConfigureAwait(false);
            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }

        public async Task<T> CheckExecutionStatus<T>() 
        {
            var link = Environment.GetEnvironmentVariable("GET_LAST_EXECUTION");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            
            HttpResponseMessage response = await _client.GetAsync(link);
            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}