using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text;

namespace FileDownloadExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult Download()
        {
            var string_with_your_data = "Download file with Blazor";

            var byteArray = Encoding.ASCII.GetBytes(string_with_your_data);
            var stream = new MemoryStream(byteArray);

            return File(stream, "text/plain", "your_file_name.txt");
        }
    }
}