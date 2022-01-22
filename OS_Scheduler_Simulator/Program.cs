using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OS_Scheduler_Simulator.Configuration;
using OS_Scheduler_Simulator.Contracts;
using System;

namespace OS_Scheduler_Simulator
{
    class Program
    {
        public static void Main(string[] args)
        {
            ServiceFactory.ConfigureServices();

            var allProcesses = ServiceFactory.Create<IInputService>().GetData();

            
        }
    }
}
