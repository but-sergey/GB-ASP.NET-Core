﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Controllers
{
    //[Route("Staff")]
    //[Route("Employees")]
    public class EmployeesController : Controller
    {
        //[Route("all")]
        public IActionResult Index()
        {
            return View(__Employees);
        }

        //[Route("info/{id}")]
        //[Route("info-id-{id}")]
        public IActionResult Details(int id)
        {
            var employee = __Employees.FirstOrDefault(employee => employee.Id == id);

            if (employee == null)
                return NotFound();

            return View(employee);
        }

    }
}