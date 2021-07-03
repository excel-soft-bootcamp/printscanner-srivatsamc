using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class PrintManager
    {
        public void PrintDocument(IPrinter printer)
        {
            printer.Print();
        }
    }


}
