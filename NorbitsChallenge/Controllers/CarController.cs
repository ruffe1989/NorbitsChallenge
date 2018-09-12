using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NorbitsChallenge.Dal;
using NorbitsChallenge.Helpers;
using NorbitsChallenge.Models;

namespace NorbitsChallenge.Controllers
{
    public class CarController : Controller
    {
        private readonly IConfiguration _config;

        public CarController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            var companyId = UserHelper.GetLoggedOnUserCompanyId();
            var cars = new CarDb(_config).GetCars(companyId);
            var model = new CarViewModel();
            model.Cars = cars;

            return View(model);  
        }
        [HttpPost]
        public JsonResult ShowSingelCar(string LicensePlate)
        {
            var car = new CarDb(_config).GetOneCar(LicensePlate);
            var model = new CarViewModel();
            model.Cars = car;
            return Json(model);
        }
        
        public ActionResult DeleteCar(string licensePlate)
        {
            new CarDb(_config).RemoveCar(licensePlate);

            return RedirectToAction("Index");
        }
    }
}