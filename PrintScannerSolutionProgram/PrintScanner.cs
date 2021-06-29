using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class PrintScanner
    {
        IPrintingmachine _printingmachine;
        IScanmachine _scanningmachine;

        public PrintScanner(Printer _printer)
        {
            this._printingmachine = _printer;

        }

        public  PrintScanner(Scanner _scanner)
        {
            this._scanningmachine = _scanner;
        }

        public  PrintScanner(Printer _printer, Scanner _scanner)
        {
            this._printingmachine = _printer;
            this._scanningmachine = _scanner;
        }

        public void PrintingOnly()
        {
            _printingmachine.Print();
        }

        public void ScanningOnly()
        {
            _scanningmachine.Scan();
        }

        public void PrintAndScan()
        {
            _printingmachine.Print();
            _scanningmachine.Scan();
        }



        
    }
}
