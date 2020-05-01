using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class MotherBoard
    {
        //Member Variables (has a)
        string Manufacturer;
        CPU Processor;
        RAM TemporaryMemory;
        HardDrive Storage;
        GPU Graphics;
        public List<Applications> ApplicationsInHardDrive;

        //Conductor (spawn)
        public MotherBoard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
            ApplicationsInHardDrive = new List<Applications>();

        }
        //Member methods (can do)
        public void InstallApplications(Applications applications)
        {
            ApplicationsInHardDrive.Add(applications);
        }
    }
}
