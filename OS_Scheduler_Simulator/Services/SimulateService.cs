using OS_Scheduler_Simulator.Configuration;
using OS_Scheduler_Simulator.Contracts;
using OS_Scheduler_Simulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Services
{
    public class SimulateService : ISimulateService
    {
        public void Simulate()
        {
            var allProcesses = ServiceFactory.Create<IInputService>().GetData();
            var readyQueue = ReadyQueue.GetQueue();
            foreach(var process in allProcesses)
            {
                readyQueue.Enqueue(process);
            }

            while (!readyQueue.IsEmpty())
            {

            }
        }
    }
}
