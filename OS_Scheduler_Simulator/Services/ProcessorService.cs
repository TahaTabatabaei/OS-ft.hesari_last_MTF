using OS_Scheduler_Simulator.Configuration;
using OS_Scheduler_Simulator.Contracts;

namespace OS_Scheduler_Simulator.Services
{
    public class ProcessorService : IProcessorService
    {
        public void ProcessInCycle()
        {
            var process = ServiceFactory.Create<ISchedulingService>().GetTask();
            process.ProcessInCycle();
        }
    }
}