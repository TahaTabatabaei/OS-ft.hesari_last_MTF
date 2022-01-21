using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OS_Scheduler_Simulator.Configuration;
using System;

namespace OS_Scheduler_Simulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            ServiceFactory.ConfigureServices();


        }
    }
}
