using OS_Scheduler_Simulator.Contracts;
using OS_Scheduler_Simulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OS_Scheduler_Simulator.Services
{
    public class InputService : IInputService
    {
        public List<Process> GetData()
        {
            var processList = new List<Process>();
            int processNumber = int.Parse(Console.ReadLine());

            for(int i = 0; i< processNumber; i++)
            {
                string taskInfo = Console.ReadLine();
                var info = taskInfo.Split(" ");
                processList.Add(new Process(info[0], double.Parse(info[1])));
            }

            return processList;
        }
    }
}
