using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintScannerSolutionProgram
{
    public class ScanManager
    {
        public void ScanDocument(IScanner scaner)
        {
            scaner.Scan();
        }
    }

}
