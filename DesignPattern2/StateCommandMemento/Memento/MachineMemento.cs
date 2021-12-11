using DesignPattern2.StateCommandMemento.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.StateCommandMemento.Memento
{
    public class MachineMemento
    {
        public PrintMachine Printer { get; set; }
        public List<MachineCommand> WordList { get; set; }

        public MachineMemento(PrintMachine printer, List<MachineCommand> wordList)
        {
            Printer = printer;
            WordList = wordList;
        }


        public void Restore()
        {
            Console.WriteLine("Reseting list and turning off...");
            Printer.WordList.Clear();
            Printer.MachineState = new MachineOff();

        }


    }
}
