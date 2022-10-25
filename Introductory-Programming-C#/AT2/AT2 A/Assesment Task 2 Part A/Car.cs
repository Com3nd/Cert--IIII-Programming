using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Car
    {
        //Seting car objects and its properites

        public int RegistrationNumber { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Car_Image { get; set; }

        public Car(int registrationNumber, string make, string model, int year, float price, string car_Image)
        {
            RegistrationNumber = registrationNumber;
            Make = make;
            Model = model;
            Year = year;
            Price = price;
            Car_Image = car_Image;
        }

        public override string ToString()
        {
            return $"{RegistrationNumber} {Make} {Model} {Year} {Price}$";
        }
    }
}
