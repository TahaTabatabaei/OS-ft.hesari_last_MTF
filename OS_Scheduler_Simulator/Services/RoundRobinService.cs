using OS_Scheduler_Simulator.Contracts;
using OS_Scheduler_Simulator.Entities;
using OS_Scheduler_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Services
{
    public class RoundRobinService : ISchedulingService
    {
        public SchedulingAlgorithmType Type { get; set; } = SchedulingAlgorithmType.Preemptive;
        
        public const int RoundRobinStep = 1;

        Process lastProcess = null;
        int roundRobinCurrentStep = 0;
        public Process GetTask()
        {
            var readyQueue = ReadyQueue.GetQueue();

            if(roundRobinCurrentStep == RoundRobinStep || lastProcess == null || lastProcess.State == ProcessState.Done)
            {

                if (lastProcess != null && lastProcess.State == ProcessState.Active)
                {
                    lastProcess.SetStateReady();
                    readyQueue.Enqueue(lastProcess);
                }

                if (readyQueue.IsEmpty())
                {
                    return null;
                }
                roundRobinCurrentStep = 0;
                lastProcess = readyQueue.Dequeue();
            }

            roundRobinCurrentStep++;
            return lastProcess;
        }
    }
}
