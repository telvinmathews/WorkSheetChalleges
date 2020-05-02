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
        public string Manufacturer;
        CPU Processor;
        RAM TemporaryMemory;
        HardDrive Storage;
        GPU Graphics;

        //Conductor (spawn)
        public MotherBoard(string manufacturer, CPU cpu, RAM ram, HardDrive hardDrive, GPU gpu)
        {
            Manufacturer = manufacturer;
            TemporaryMemory = ram;
            Processor = cpu;
            Storage = hardDrive;
            Graphics = gpu;
        }
        //Member methods (can do)
        public void InstallApplications(Applications applications)
        {
            if (TemporaryMemory.TotalGigabytes > applications.RequiredRam && Storage.AvailableStorage > applications.RequiredStorage)
            {
                Storage.ApplicationsInHardDrive.Add(applications);
            }
        }
    }
}
