using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.StateCommandMemento.Command
{
    public class MachineCommand : ICommand
    {
        public IMachine Machine { get; set; }
        public string Word { get; set; }
        public MachineCommand(IMachine machine, string word)
        {
            Machine = machine;
            Word = word;
        }
        public void Execute()
        {
            Machine.Print(Word);
        }
    }
}
