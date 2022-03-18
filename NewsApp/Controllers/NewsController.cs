using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Models;
using RepositoryLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using NewsApp.Models;

namespace NewsApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly NewsContext context;
        private readonly IWebHostEnvironment _env;
        public NewsController(NewsContext _context, IWebHostEnvironment hostingEnv)
        {
            context = _context;
            _env = hostingEnv;
        }
        public IActionResult Index()
        {
            List<News> _news = new NewsDA(context).GetAllNews();
            return View(_news);
        }

        public IActionResult AddNew()
        {
            List<School> _schools = new NewsDA(context).GetAllSchool();
            return View(_schools);
        }

        public IActionResult GetNews(int id)
        {
            News _news = new NewsDA(context).GetByNewsId(id);
            return View(_news);
        }

        [HttpPost]
        public async Task<IActionResult> AddNews([FromForm] NewsAdd newsAdd)
        {
            try
            {
                IFormFileCollection files = Request.Form.Files;
                Random random = new Random(); 
                string num = "F" + random.Next().ToString() + DateTime.Now.ToString("ddMMMyyyyHHMMss");

                foreach (FormFile each_file in files)
                {

                    string path = Path.Combine(_env.WebRootPath, "Uploads", num);
                    if (!Directory.Exists(path))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(path);
                    }
                    string FileName = each_file.Name;
                    char NewsFileMode = FileName[0];
                    if(NewsFileMode == 'F')
                    {
                        newsAdd.SetProfilePicture(Path.Combine(num, each_file.FileName));
                    }
                    else if (NewsFileMode == 'A')
                    {
                        newsAdd.AddAttachments(Path.Combine(num, each_file.FileName));
                    }
                    string filePath = Path.Combine(path, each_file.FileName);
                    using FileStream stream = new FileStream(filePath, FileMode.Create);

                    await each_file.CopyToAsync(stream);
                }
                string successmessage = new NewsDA(context).Save(newsAdd.CreateNewsDataModel());
                return Json(successmessage);
            }
            catch (Exception ex)
            {
                //return Json(new { status = "error " + ex.Message });
                return Json("Failed");
            }
        }

        public JsonResult GetAll(int thresoldValue)
        {
            List<News> _news = new NewsDA(context).GetAllNews(thresoldValue);
            return Json(_news);
        }
    }
}
