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

        public void ProcessInstallApp(Applications app, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(app);
        } 
        public void ProcessInstallGame(Game game, HardDrive hardDrive, RAM ram)
        {
            hardDrive.ApplicationsInHardDrive.Add(game);
        }

        public void CheckRequirementsForApp(Applications app, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (ram.TotalGigabytes > app.RequiredRam && hardDrive.AvailableStorage > app.RequiredStorage)
            {
                ProcessInstallApp(app,hardDrive,ram);
            }
        }
        public void CheckRequirementsForGame(Game game, HardDrive hardDrive, RAM ram, GPU gpu)
        {
            if (ram.TotalGigabytes > game.RequiredRam && hardDrive.AvailableStorage > game.RequiredStorage && gpu.EffectiveMemory > game.RequiredEffectiveMemory)
            {
                ProcessInstallApp(game,hardDrive,ram);
            }
        }
    }
}
