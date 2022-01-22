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

        public Process GetTask()
        {
            throw new NotImplementedException();
        }
    }
}
