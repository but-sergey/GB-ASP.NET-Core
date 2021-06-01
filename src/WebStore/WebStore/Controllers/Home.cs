﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using WebStore.Models;

namespace WebStore.Controllers
{
    //[Controller]
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 27 },
            new Employee { Id = 2, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 31 },
            new Employee { Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 18 },
        };

        private readonly IConfiguration _Configuration;

        public HomeController(IConfiguration Configuration)
        { 
            _Configuration = Configuration;
        }

        public IActionResult Index() => View();

        public IActionResult Blog() => View();

        public IActionResult BlogSingle() => View();

        public IActionResult Cart() => View();

        public IActionResult Checkout() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Error404() => View();

        public IActionResult Login() => View();

        public IActionResult ProductDetails() => View();

        public IActionResult Shop() => View();

        public IActionResult SecondAction()
        {
            return View("Index");
        }

        public IActionResult Employees()
        {
            return View(__Employees);
        }

        public IActionResult EmployeDetails(int id)
        {
            var employee = __Employees.FirstOrDefault(employee => employee.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }
    }
}
