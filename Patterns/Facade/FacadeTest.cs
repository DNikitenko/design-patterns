using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Facade
{
    class FacadeTest : IPatternTest
    {
        public void Run()
        {
            var googlePage = DownloadManager.GetText("https://google.com/");
            Console.WriteLine(googlePage);
            Console.ReadKey();
        }
    }
}
