using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class HardDrive
    {
        //Member variable (Has a)
        public double TotalStorage;
        public double AvailableStorage;
        public List<Applications> ApplicationsInHardDrive;
        //Conductor (Spawn)
        public HardDrive(double totalStorage, double availableStorage)
        {
            TotalStorage = totalStorage;
            AvailableStorage = availableStorage;
            ApplicationsInHardDrive = new List<Applications>();
        }
        //Member method (Can do)


    }
}
