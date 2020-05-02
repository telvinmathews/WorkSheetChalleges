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
        public MotherBoard MotherBoard;
        public CPU CPU;
        public RAM RAM;
        public HardDrive HardDrive;
        public GPU GPU;
        //Conductor (Spawn)
        public Computer()
        {
            MotherBoard = new MotherBoard("Msi", CPU, RAM, HardDrive, GPU);
            CPU = new CPU("IBM", "Intel");
            RAM = new RAM(16, "OCZ");
            HardDrive = new HardDrive(250, 250);
            GPU = new GPU("Nvaida", 8);
        }
        //Member method (Can do)

        public void Intstall(Game game)
        {
            CPU.CheckRequirementsForGame(game, HardDrive, RAM, GPU);
            CPU.ProcessInstallGame(game, HardDrive, RAM);
        }
        

    }
}
