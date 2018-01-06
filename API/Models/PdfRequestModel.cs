using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class PdfRequestModel
    {
        public string Url { get; set; }
        public string OutputDirectory { get; set; }
    }
}