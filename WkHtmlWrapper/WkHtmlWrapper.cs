using System;
using Utilities;

namespace Wrapper
{
    public static class WkHtmlWrapper
    {
        public static void CreatePdfFromUrl(string url, string outputUrl = "test.pdf")
        {
            if (String.IsNullOrEmpty(url) || String.IsNullOrEmpty(outputUrl))
            {
                throw new ArgumentException("Url not supplied");
            }
            CommandLineProcessCreator creator = new CommandLineProcessCreator();
            var process = creator.CreateService($"wkhtmltopdf {url} {outputUrl}");
            process.Start();
        }
    }
}
