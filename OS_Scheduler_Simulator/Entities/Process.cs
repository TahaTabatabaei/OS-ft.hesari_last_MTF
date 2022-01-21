using OS_Scheduler_Simulator.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Entities
{
    public class Process
    {
        public readonly double ExpectedTime;
        
        public ProcessState State
        {
            get { return State; }
            private set
            {
                State = value;
            }
        }

        public double RemainingJob
        {
            get
            {
                return RemainingJob;
            }
            private set
            {
                RemainingJob = value;
            }
        }

        public Process(double expectedTime)
        {
            this.ExpectedTime = expectedTime;
            this.RemainingJob = expectedTime;
        }



    }
}
