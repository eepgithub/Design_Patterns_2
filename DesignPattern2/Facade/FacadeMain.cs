using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.Facade
{
    class FacadeMain
    {
        public void Run()
        {
            
            WordFacade WordFacade = new ();

            WordFacade.Save();
            WordFacade.Load();

        }
    }
}
