using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.Adapter
{
    class AdapterMain
    {

        public void Run()
        {
           
            IPrintingIntsService printingIntsService = new PrintingIntsService();

            printingIntsService.Print();

        }


    }
}
