using OS_Scheduler_Simulator.Contracts;
using OS_Scheduler_Simulator.Entities;
using OS_Scheduler_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OS_Scheduler_Simulator.Services
{
    public class SJFService : ISchedulingService
    {
        public SchedulingAlgorithmType Type { get; set; } = SchedulingAlgorithmType.NonPreemptive;

        public Process GetTask()
        {
            var readyQueue = ReadyQueue.GetQueue();
            var minRemainingJob = readyQueue.Where(p => p.State != ProcessState.Done).Min(p => (double?)p.RemainingJob);
            if(minRemainingJob == null)
            {
                return null;
            }
            return readyQueue.Where(p => p.RemainingJob == minRemainingJob).First();
        }
    }
}
