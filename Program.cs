using System;
using dotenv.net;
using System.Threading.Tasks;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Config();
            //ExecutionClient.StartExecution();
            ExecutionClient execution = new ExecutionClient();
            ExecutionStatus result = execution.StartExecution<ExecutionStatus>().Result;
            Console.WriteLine(result.status); 
        }
    }
}
