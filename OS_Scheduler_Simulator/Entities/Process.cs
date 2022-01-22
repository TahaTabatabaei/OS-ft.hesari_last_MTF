using OS_Scheduler_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Entities
{
    public class Process
    {
        public readonly double ExpectedTime;
        private string processName;
        public string ProcessName
        {
            get
            {
                return processName;
            }
            private set
            {
                this.processName = value;
            }
        }
        private ProcessState state;
        public ProcessState State
        {
            get { return State; }
            private set
            {
                state = value;
            }
        }
        private double remainingJob;
        public double RemainingJob
        {
            get
            {
                return remainingJob;
            }
            private set
            {
                remainingJob = value;
            }
        }

        public Process(string processName,double expectedTime)
        {
            this.ProcessName = processName;
            this.ExpectedTime = expectedTime;
            this.RemainingJob = expectedTime;
        }

        public void ProcessInCycle()
        {
            if((--this.RemainingJob) == 0)
            {
                this.State = ProcessState.Done;
            }
        }

    }
}
