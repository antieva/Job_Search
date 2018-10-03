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
            
            ExecutionClient execution = new ExecutionClient();
            ExecutionStatus result = execution.StartExecution<ExecutionStatus>().Result;
            Console.WriteLine(result.status); 
            result = execution.CheckExecutionStatus<ExecutionStatus>().Result;
            Console.WriteLine(result.status); 
        }
    }
}
