using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template_Method
{
    class TemplateMethodTest : IPatternTest
    {
        public void Run()
        {
            var reportGenerator = new PrimEcoEnergoReportGenerator();
            Console.WriteLine(reportGenerator.GetReport());
            Console.ReadKey();
        }
    }
}
