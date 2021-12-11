using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern2.Adapter
{
    public interface IPrintingIntsService
    {
        public int Converter();
        public void Print();
    }
}
