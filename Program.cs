﻿using System;
using dotenv.net;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DotEnv.Config();

            Console.WriteLine("sdsdsdsd");
            ExecutionClient.A();
        }
    }
}