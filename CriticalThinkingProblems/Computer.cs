using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinkingProblems
{
    class Computer
    {
        //Member variable (Has a)
        MotherBoard MotherBoard;
        CPU CPU;
        RAM RAM;
        HardDrive HardDrive;
        GPU GPU;
        //Conductor (Spawn)
        public Computer()
        {
            MotherBoard = new MotherBoard("Msi", CPU,RAM,HardDrive,GPU);
            CPU = new CPU("IBM", "Intel");
            RAM = new RAM(16, "OCZ");
            HardDrive = new HardDrive(250, 250);
            GPU = new GPU("Nvaida", 4);

        }
        //Member method (Can do)
        

    }
}
