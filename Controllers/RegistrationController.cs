using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;
using MvcDemo.Services;

namespace MvcDemo.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AgeCalculationService _ageCalculationService;

        public RegistrationController(AgeCalculationService ageCalculationService)
        {
            _ageCalculationService = ageCalculationService;
        }

        public IActionResult Index()
        {
            var model = new RegistrationModel();
            return View(model);
        }
        public IActionResult Post(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            model.Birthdate = (DateTime)_ageCalculationService.CalculateBirthDateFromAge(model.Age);

            return  View(model);
        }
    }
}
