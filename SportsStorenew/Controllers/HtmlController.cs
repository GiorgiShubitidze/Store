
using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Net;

namespace SportsStorenew.Controllers
{
    public class HtmlController : Controller
    {
        public IActionResult Index()
        {
            var htmlDoc = new HtmlDocument();

            htmlDoc.LoadHtml(MakeRequest("https://amindi.ge"));
            string title = htmlDoc.DocumentNode.SelectSingleNode("//body").InnerText;
            return Content(title);
        }
        public string MakeRequest(string url)
        {
            string html = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
                return html;
        }
    }
}
