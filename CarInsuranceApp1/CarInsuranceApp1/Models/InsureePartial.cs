using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceApp1.Models
{
    public static class InsureePartial
    {
        public static decimal CalculateQuote(Table1Insurees insuree)
        {
            decimal baseRate = 50m; // Base insurance rate

            int age = DateTime.Now.Year - insuree.DateOfBirth.Year; // calculate client's age from DoB

            // Add cost based on age
            if (age <= 18) baseRate += 100;
            else if (age >= 19 && age <= 25) baseRate += 50;
            else if (age > 25) baseRate += 25;

            if (insuree.CarYear < 2000) baseRate += 25;
            if (insuree.CarYear > 2015) baseRate += 25;
            if (insuree.CarMake == "Porsche" && insuree.CarModel != "911 Carrera") baseRate += 25;
            if (insuree.CarMake == "Porsche" && insuree.CarModel == "911 Carrera") baseRate += 50;

            // speeding tickets
            baseRate += insuree.SpeedingTickets * 10;

            if (insuree.DUI == true) baseRate *= 1.25m; // add 25% to overall cost if DUI is true
            if (insuree.CoverageType == true) baseRate *= 1.5m;
          
            return baseRate;
        }
    }
}
