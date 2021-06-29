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

            PrintManager _printManager = new PrintManager(new Printer());
            _printManager.Print(_printer);

            ScanManager _scanManager = new ScanManager(new Scanner());
            _scanManager.Scan(_scanner);

            PrintScanner _printOnly = new PrintScanner(new PrintManager(new Printer()));
            _printOnly.PrintingOnly();

            PrintScanner _scanOnly = new PrintScanner(new ScanManager(new Scanner()));
            _scanOnly.ScanningOnly();

            PrintScanner _printAndScan = new PrintScanner(new PrintManager(new Printer()), new ScanManager(new Scanner()));
            _printAndScan.PrintAndScan();

        }
    }
}

