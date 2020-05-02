using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class CPU
    {
        //Member variable (Has a)
        public string Manufacturer;
        public string Name;
        //Conductor (Spawn)
        public CPU(string manufacturer, string name)
        {
            Manufacturer = manufacturer;
            Name = name;
        }
        //Member method (Can do)

        public void ProcessInstall(Applications app, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
        }

        public void CheckRequirements(Applications app, HardDrive hardDrive, RAM ram)
        {
            if (ram.TotalGigabytes > app.RequiredRam && hardDrive.AvailableStorage > app.RequiredStorage)
            {
                ProcessInstall(app,hardDrive,ram);
            }
        }
    }
}
