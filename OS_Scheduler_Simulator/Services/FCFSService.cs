

using OS_Scheduler_Simulator.Contracts;
using OS_Scheduler_Simulator.Entities;
using OS_Scheduler_Simulator.Enums;

namespace OS_Scheduler_Simulator.Services
{
    public class FCFSService : ISchedulingService
    {
        public SchedulingAlgorithmType Type { get; set; } = SchedulingAlgorithmType.NonPreemptive;
        private Process lastProcess = null;
        public Process GetTask()
        {
            var readyQueue = ReadyQueue.GetQueue();
            
            if (lastProcess == null || lastProcess.State == ProcessState.Done)
            {
                if (readyQueue.IsEmpty())
                {
                    return null;
                }
                this.lastProcess = readyQueue.Dequeue();
            }

            return this.lastProcess;
        }
    }
}