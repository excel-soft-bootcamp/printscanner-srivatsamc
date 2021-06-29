using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class PrintManager:Printer
    {

        public void Print(Printer parameter)
        {
            parameter.Print();
          
        }

    }
}
