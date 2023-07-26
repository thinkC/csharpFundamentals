using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanyPieShopHRM1
{

    internal class Vehicle
    {
        public string model;
        public string color;
        public int currentMileage;

        public Vehicle()
        {

        }

        public Vehicle(int currentMileage, string model, string color)
        {
            model = model;
            color = color;
            currentMileage = currentMileage;
        }

        public void Drive()
        {
            currentMileage = currentMileage + 1;
        }

        public void Drive(int miles)
        {
            if (currentMileage > 0)
            {
                currentMileage += miles;
            }
        }

        public string DisplayVehicleDetails()
        {
            return $"Model: model - Color: color - Current mileage: currentMileage";
        }

    }
}
