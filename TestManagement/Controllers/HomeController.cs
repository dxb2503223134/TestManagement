using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestManagement.Models;

namespace TestManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;

        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public string Index()
        {
            // 返回学生名字
            return _studentRepository.GetStudent(1).Name;
        }
        public IActionResult Details()
        {
            var model = _studentRepository.GetStudent(1);
            //return View("~/MyViews/Test.cshtml");
            return View("../../MyViews/Details"); //去掉后缀
        }
    }
}