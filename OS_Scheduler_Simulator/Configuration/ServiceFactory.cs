using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Configuration
{
    public static class ServiceFactory
    {
        private static ServiceProvider _serviceProvider;
        internal static void ConfigureServices()
        {
            ServiceFactory._serviceProvider = new ServiceCollection().AddLogging().BuildServiceProvider();
        }

    }
}
