using OS_Scheduler_Simulator.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OS_Scheduler_Simulator.Entities
{
    public class ReadyQueue : IEnumerable<Process>
    {

        #region SingletonImplementation
        private static ReadyQueue appQueue = null;
        private static object padlock = new object();
        public static ReadyQueue GetQueue()
        {
            lock (padlock)
            {
                if (ReadyQueue.appQueue == null)
                {
                    appQueue = new ReadyQueue();
                }
            }

            return appQueue;
        }

        private ReadyQueue()
        {

        }
        #endregion

        private Queue<Process> readyQueue = new Queue<Process>();

        public IEnumerator<Process> GetEnumerator()
        {
            return this.readyQueue.GetEnumerator();
        }

        //public Process GetShortestRemainigJob()
        //{
        //    var minimumRemaininigJob = this.Where(p => p.State != ProcessState.Done).Min(p => p.RemainingJob);
        //    return this.Where(p => p.RemainingJob == minimumRemaininigJob).FirstOrDefault();
        //}

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.readyQueue.GetEnumerator();
        }

        public Process Dequeue()
        {
            return this.readyQueue.Dequeue();
        }

        public bool IsEmpty()
        {
            return this.readyQueue.Count == 0;
        }

        public void Enqueue(Process process)
        {
            if (process.State != ProcessState.Ready)
            {
                throw new Exception("Cannot add non-ready states into ready-queue");
            }
            this.readyQueue.Enqueue(process);
        }
    }
}
