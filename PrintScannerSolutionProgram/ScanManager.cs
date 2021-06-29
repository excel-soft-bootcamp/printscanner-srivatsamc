using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class ScanManager:Scanner
    {
        IScanmachine scanMachineValue;
        public ScanManager(Scanner scannerParameter)
        {
            this.scanMachineValue = scannerParameter;
        }
        public void Scan(Scanner parameter)
        {
            scanMachineValue.Scan();

        }

    }
}
