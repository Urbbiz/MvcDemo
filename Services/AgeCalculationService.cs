using Microsoft.AspNetCore.Mvc;

namespace MvcDemo.Services
{
    public class AgeCalculationService
    {
      public DateTime? CalculateBirthDateFromAge(int age)
        {
            var currentDate = DateTime.Now;

            return currentDate.AddYears(age * (-1));
        }
    }
}
