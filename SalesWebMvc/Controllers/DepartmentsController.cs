using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
        
            List<Department> lista = new List<Department>();
            lista.Add(new Department { Id = 1, Nome = "Eletronics", dataPgto = "09/04/2023"});
            lista.Add(new Department { Id = 2, Nome = "Fashion", dataPgto = "05/02/2023"});
            

            return View(lista);
        }
    }
}
