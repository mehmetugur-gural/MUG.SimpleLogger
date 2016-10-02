using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MUG.SimpleLogger.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            new CoreLevelExceptionTest().RunTest();
            new CriticalUserLevelExceptionTest().RunTest();
        }
    }
}
