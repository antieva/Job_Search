using System;

namespace myApp
{
    public class ExecutionClient 
    {
        public static void A() 
        {
            Console.WriteLine(Environment.GetEnvironmentVariable("LINK"));
        }
    }
}