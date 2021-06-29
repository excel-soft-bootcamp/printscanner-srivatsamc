using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer _printer = new Printer();
            _printer.Print();

            Scanner _scanner = new Scanner();
            _scanner.Scan();

            PrintManager _printManager = new PrintManager();
            _printManager.Print(_printer);

            ScanManager _scanManager = new ScanManager();
            _scanManager.Scan(_scanner);

            PrintScanner _printOnly = new PrintScanner(new PrintManager());
            _printOnly.PrintingOnly();

            PrintScanner _scanOnly = new PrintScanner(new ScanManager());
            _scanOnly.ScanningOnly();

            PrintScanner _printAndScan = new PrintScanner(new PrintManager(), new ScanManager());
            _printAndScan.PrintAndScan();

        }
    }
}

