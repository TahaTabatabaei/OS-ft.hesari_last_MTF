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
            foreach (var process in allProcesses)
            {
                readyQueue.Enqueue(process);
            }

            var cycleNumber = 1;

            var taskToProcess = ServiceFactory.Create<ISchedulingService>().GetTask();
            while (taskToProcess != null)
            {
                Console.WriteLine($"Process In cycle {cycleNumber++}: Processing Task with name {taskToProcess.ProcessName}");
                taskToProcess.ProcessInCycle();
                taskToProcess = ServiceFactory.Create<ISchedulingService>().GetTask();
            }
        }
    }
}
