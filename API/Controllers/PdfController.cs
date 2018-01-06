using System.Web.Http;
using API.Models;
using Wrapper;

namespace API.Controllers
{
    [AllowAnonymous]
    public class PdfController : ApiController
    {
        [HttpPost]
        public IHttpActionResult ConvertUrlToPdf(PdfRequestModel request)
        {
            var mappedPath = System.Web.Hosting.HostingEnvironment.MapPath("~/App_Data") + "\\" + request.OutputDirectory;
            var wkhtmlPath = System.Web.Hosting.HostingEnvironment.MapPath("~/Bin") + "\\wkhtmltopdf";
            var response = WkHtmlWrapper.CreatePdfFromUrl(request.Url, mappedPath, wkhtmlPath);
            return Ok(response);
        }
    }
}
