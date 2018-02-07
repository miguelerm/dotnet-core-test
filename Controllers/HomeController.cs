using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using mvc_test.Models;
using mvc_test.Filters;
using mvc_test.Services;
using System.Collections;

namespace mvc_test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string id = "html")
        {

            if (id == "json") {
                return Json(new { Id = 0, Name = "asdf" });
            }

            if (id == "img") {
                var file = System.IO.File.ReadAllBytes(@"C:\Users\miguelr\Pictures\19_Suicide-Squad.jpg");
                return File(file, "image/jpeg");
            }

            if (id == "text") {
                return Content("1,2", "text/csv");
            }

            return View();
        }

        private string Test() {
            return "Hola AW";
        }

        public IActionResult Blog(int year, int month, int day) {
            return Content($"{year}/{month}/{day}");
        }

        public IActionResult BlogArticle(string category, string subcategory, string article) {
            return Content($"{category}/{subcategory}/{article}");
        }

        //[LogActionFilter]
        [HighLightToyotaFilter]
        public IActionResult BlogMakeModel(string make, string model, string zipCode) {
            var today = DateTime.Now;
            return Content($"Make: {make}; Model: {model}; zipCode: {zipCode} ({today:dd-yyyy-MM HH:mm:ss})");
        }


        public IActionResult CrearEmpleado([FromBody] EmpleadoViewModel viewModel)
        {
            // TODO: convertir la validacion a un global filter
            /*if (!ModelState.IsValid) {
                return BadRequest(ModelState);
            }*/

            var empleados = new EmpleadoService();
            var id = empleados.Crear(viewModel);

            var sucess = id > 0;
            var message = sucess ? "OK": "KO";

            var result = new EmpleadoCreadoViewModel(sucess) {
                Message = message
            };

            return Ok(result);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
