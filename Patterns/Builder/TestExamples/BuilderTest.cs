using Patterns.Builder.Builders;
using Patterns.Builder.RequestRunners;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder.TestExamples
{
    class BuilderTest : IPatternTest
    {
        private void WriteFile(string fileName, string fileContents)
        {
            using (var fs = new FileStream(fileName, FileMode.Create))
            using (var sw = new StreamWriter(fs))
            {
                sw.Write(fileContents);
            }
        }

        private void DownloadVkHomePage()
        {
            var getBuilder = new GetRequestBuilder("https://vk.com/");
            var vkDownloadManager = new DefaultWebRequestManager(getBuilder);

            vkDownloadManager.ConfigureRequest();
            var page = getBuilder.GetRequestResult();

            WriteFile("vk.html", page);
        }

        private void DownloadElibrary()
        {
            var postBuilder = new PostRequestBuilder("http://elibrary.ru/");
            var elibraryDownloadManager = new DefaultWebRequestManager(postBuilder, "page=1");

            elibraryDownloadManager.ConfigureRequest();
            var page = postBuilder.GetRequestResult();

            WriteFile("elibrary.html", page);
        }

        public void Run()
        {
            DownloadVkHomePage();
            DownloadElibrary();
        }
    }
}
