using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    public class Parking
    {
        private Dictionary<string, Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            this.Capacity = capacity;
            this.Cars = new Dictionary<string, Car>(capacity);
        }

        public int Capacity
        {
            get { return this.capacity; }
            set { this.capacity = value; }
        }

        public Dictionary<string, Car> Cars
        {
            get { return this.cars; }
            set { this.cars = value; }
        }
        public int Count
        {
            get { return this.cars.Count; }
        }

        public string AddCar(Car car)
        {
            if (this.Cars.ContainsKey(car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (this.Cars.Count == this.Capacity)
            {
                return "Parking is full!";
            }

            this.Cars.Add(car.RegistrationNumber, car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            if (!this.Cars.ContainsKey(registrationNumber))
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.Cars.Remove(registrationNumber);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            return this.cars[registrationNumber];
        }

        public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string registrationNumber in RegistrationNumbers)
            {
                if (this.cars.ContainsKey(registrationNumber))
                {
                    this.cars.Remove(registrationNumber);
                }
            }
        }
    }
}
