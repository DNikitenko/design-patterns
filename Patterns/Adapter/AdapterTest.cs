using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    class AdapterTest : IPatternTest
    {
        public void Run()
        {
            var fileTextRetriever = TextRetrieverFactory.CreateFileTextRetriever("test.txt");
            var fileViewer = new TextViewer(fileTextRetriever);
            fileViewer.ShowText();

            var mailPageRetriever = TextRetrieverFactory.CreateWebPageRetriever("http://vladivostok.com");
            var mailPageViewer = new TextViewer(mailPageRetriever);
            mailPageViewer.ShowText();

            Console.ReadKey();
        }
    }
}
