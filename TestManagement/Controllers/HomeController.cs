using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestManagement.Models;
using TestManagement.ViewModels;

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
            //var model = _studentRepository.GetStudent(1);

            //ViewBag.PageTitle = "学生详情";
            //ViewBag.Student = model;

            //ViewData["PageTitle"] = "StudentDetails";
            //ViewData["Student"] = model;

            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel
            {
                Student = _studentRepository.GetStudent(1),
                PageTitle = "Student Details"
            };

            return View(homeDetailsViewModel);

            //return View("~/MyViews/Test.cshtml"); //带上后缀
            //return View("../../MyViews/Details"); //去掉后缀
        }

        public string Test()
        {
            return string.Empty;
        }
    }
}