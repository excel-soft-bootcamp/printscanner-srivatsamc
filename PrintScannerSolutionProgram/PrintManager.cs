using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class PrintManager:Printer
    {
        IPrintingmachine printingMachineValue;
        public PrintManager(Printer printerParameter)
        {
            this.printingMachineValue = printerParameter;
        }
        public void Print(Printer parameter)
        {
            printingMachineValue.Print();
          
        }

    }
}
