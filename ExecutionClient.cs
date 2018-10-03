using System;
using System.Net.Http;
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
            Console.WriteLine(link);
            HttpResponseMessage response = await _client.PostAsync(link, null).ConfigureAwait(false);
            var result = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<T>(result);
        }
    }
}