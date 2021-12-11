using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.StateCommandMemento.State
{
    public class MachineOn : IMachineState
    {
        public void PowerSwitch()
        {
            Console.WriteLine("Turning off \n");
        }
    }
}
