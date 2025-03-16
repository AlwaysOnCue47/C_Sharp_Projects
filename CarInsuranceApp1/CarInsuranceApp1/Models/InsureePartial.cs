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

            int age = DateTime.Now.Year - insuree.DateOfBirth.Year;

            // Add cost based on age
            if (age <= 18) baseRate += 100;
            else if (age >= 19 && age <= 25) baseRate += 50;
            else if (age > 25) baseRate += 25;

            // Add cost for speeding tickets
            baseRate += insuree.SpeedingTickets * 10;
          
            return baseRate;
        }
    }
}
