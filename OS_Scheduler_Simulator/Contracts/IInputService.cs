using OS_Scheduler_Simulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Contracts
{
    public interface IInputService
    {
        public List<Process> GetData();
    }
}
