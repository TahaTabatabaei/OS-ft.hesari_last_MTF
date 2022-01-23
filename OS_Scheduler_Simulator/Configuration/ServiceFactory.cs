using Microsoft.Extensions.DependencyInjection;
using OS_Scheduler_Simulator.Contracts;
using OS_Scheduler_Simulator.Services;
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
            ServiceFactory._serviceProvider = new ServiceCollection().AddLogging()
                .AddSingleton<IInputService, InputService>()
                .AddSingleton<ISimulateService, SimulateService>()
                .AddSingleton<ISchedulingService, FCFSService>()
                .BuildServiceProvider();
        }

        public static T Create<T>()
        {
            return _serviceProvider.GetService<T>();
        }
    }
}
