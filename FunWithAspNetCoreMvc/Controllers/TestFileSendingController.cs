using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FunWithAspNetCoreMvc.Controllers
{
    public class TestFileSendingController : Controller
    {
        private readonly IHostingEnvironment appEnvironment;

        public TestFileSendingController(IHostingEnvironment appEnvironment)
        {
            this.appEnvironment = appEnvironment;
        }

        // A file can be returnes to a client by using one of the following results:
        // * FileContentResult
        // * FileStreamResult
        // * VirtualFileResult
        // * PhysicalFileResult
        public VirtualFileResult Index()
        {
            // Note: If you return VirtualFileResult then the file should
            // be placed in wwwroot directory.
            var filePath = Path.Combine("~/files", "file.txt");
            return File(filePath, "Application/txt", "file.txt");
        }

        // In this case the file isn't stored in the wwwroot folder.
        // It's located at Files folder.
        public IActionResult GetPhysicalFile()
        {
            var filePath = Path.Combine(this.appEnvironment.ContentRootPath, "Files/file2.txt");
            var fileType = "Application/txt";
            var fileName = "file2.txt";
            return PhysicalFile(filePath, fileType, fileName);
        }

        public FileResult GetFileAsArrayOfBytes()
        {
            var path = Path.Combine(this.appEnvironment.ContentRootPath, "Files/file3.txt");
            byte[] arr = System.IO.File.ReadAllBytes(path);
            var fileType = "Application/txt";
            var fileName = "file3.txt";
            return this.File(arr, fileType, fileName);
        }

        public FileResult GetFileAsStream()
        {
            string path = Path.Combine(this.appEnvironment.ContentRootPath, "Files/file4.txt");
            FileStream fs = new FileStream(path, FileMode.Open);
            var fileType = "Application/txt";
            var fileName = "file4.txt";
            return this.File(fs, fileType, fileName);
        }
    }
}