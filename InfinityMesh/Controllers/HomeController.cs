using InfinityMesh.Infrastructure;
using InfinityMesh.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace InfinityMesh.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class HomeController : Controller
    {
        private readonly IFileReader _fileReader;

        public HomeController(IFileReader fileReader) => _fileReader = fileReader;
        
        [HttpGet]
        public IActionResult Results() 
        {
            List<City> results = _fileReader.ReadResults(@"C:\vs\InfinityMesh\data.txt");
            return Json(results);
        }
    }
}
