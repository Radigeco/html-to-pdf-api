using System;
using Utilities;

namespace Wrapper
{
    public static class WkHtmlWrapper
    {
        public static ResponseModel CreatePdfFromUrl(string url, string outputUrl = "test.pdf", string wkhtmlPath = "wkhtmltopdf")
        {
            if (String.IsNullOrEmpty(url) || String.IsNullOrEmpty(outputUrl))
            {
                throw new ArgumentException("Url not supplied");
            }
            CommandLineProcessCreator creator = new CommandLineProcessCreator();
            var process = creator.CreateService($"{wkhtmlPath} {url} {outputUrl}");
            process.StartInfo.RedirectStandardError = true;

            process.Start();

            process.WaitForExit();

            ResponseModel response = new ResponseModel
            {
                ExitCode = process.ExitCode,
                StandardError = process.StandardError.ReadToEnd(),
                StandardOut = process.StandardOutput.ReadToEnd()
            };
            return response;
        }
    }

    public class ResponseModel
    {
        public int ExitCode { get; set; }
        public string StandardOut { get; set; }
        public string StandardError { get; set; }
    }
}
