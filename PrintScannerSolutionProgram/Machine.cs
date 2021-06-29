using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class Machine
    {
        IPrintingmachine printingmachine;
        IScanmachine scanningmachine;

        public void CallPrinter()
        {
            this.printingmachine.Print();
        }

        public void CallScanner()
        {
            this.scanningmachine.Scan();
        }

    }
}
