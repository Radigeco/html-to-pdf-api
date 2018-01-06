using Utilities;
using Wrapper;

namespace HtmlToPdfConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            //google test
            WkHtmlWrapper.CreatePdfFromUrl("www.google.com", "google.pdf");
            WkHtmlWrapper.CreatePdfFromUrl("www.yahoo.com","yahoo.pdf");

        }
    }
}
