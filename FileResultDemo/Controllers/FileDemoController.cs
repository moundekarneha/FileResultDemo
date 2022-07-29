using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileResultDemo.Controllers
{
    public class FileDemoController : Controller
    {
        // GET: FileDemo
        public FileResult Index()
        {
            return File("~/ContentsData/habbits.pdf","application/pdf");
        }
    }
}