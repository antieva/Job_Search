using System;
using System.Net.Http;

namespace myApp
{
    public class ExecutionClient 
    {
        private readonly HttpClient _client = new HttpClient();
        public static void StartExecution() 
        {
            var link = Environment.GetEnvironmentVariable("START_EXECUTION");
            Console.WriteLine(link);
        }
    }
}