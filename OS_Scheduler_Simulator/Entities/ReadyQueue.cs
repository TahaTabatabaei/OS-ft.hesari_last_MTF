using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Entities
{
    public class ReadyQueue : IEnumerable<Process>
    {
        private Queue<Process> Queue { get; set; }
        public IEnumerator<Process> GetEnumerator()
        {
            return this.Queue.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
