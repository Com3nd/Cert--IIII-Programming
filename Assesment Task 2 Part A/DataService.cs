using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class DataService
    {
        //Setting up DataServices to store all of the data

        private Car[] Cars = new Car[20];
        private List<Car> SoldCarsList = new List<Car>();

        public DataService()
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                Cars[i] = new Car(i + 1, "Ford", "Mustang", 2015, 50000, "Cars_Mustang");
            }
        }

        //Get method to get the cars array
        public Car[] GetCars()
        {
            return Cars;
        }

        //Private method to check if there is any empty car slot
        private int VacancyCheck(Car[] cars)
        {
            for (int i = 0; i < cars.Length; i++)
            {
                if (cars[i] == null)
                {
                    return i;
                }
            }

            return -1;
        }

        //Method that intiates the selling of a car
        public void SellCar(Car oldCar)
        {
            for (int i = 0; i < Cars.Length; i++)
            {
                if (oldCar == Cars[i])
                {
                    Cars[i] = null;

                    SoldCarsList.Add(oldCar);
                }
            }
        }

        //Method for adding a car to inventory
        public void AddCar(Car newCar)
        {
            int vacantIndex = VacancyCheck(Cars);

            if (vacantIndex > -1)
            {
                Cars[vacantIndex] = newCar;
            }
        }

    }
}
