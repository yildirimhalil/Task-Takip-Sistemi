using Microsoft.AspNetCore.Mvc;
using TaskTakipSistemi.Models;

namespace TaskTakipSistemi.Controllers
{
    public class TaskController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }   
        public IActionResult Apply()
        {
            return View();
        }   
       
        [HttpPost]
        public IActionResult Apply(Employee model)
        {
            return View();
        }   
    }
}