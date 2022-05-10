using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {

        public string CompanyName { get; set; } = "Ford";
        public string Logo { get; set; } = "White Horse";
        string IVehicle.Year { get; set; } = "1995";
        string IVehicle.Color { get; set; } = "White";
        string IVehicle.Model { get; set; } = "F150";
        int IVehicle.SeatCount { get; set; } = 5;

        public bool HasHitch { get; set; }


        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} now going forword");
            if (HasHitch == true)
            {
                Console.WriteLine("And can pull the Trailer");
            }
            else
            {
            }

        }
        public void Reverse()
        {
            Console.WriteLine($"The {GetType().Name} now going backwards");
        }
        public void park()
        {
            Console.WriteLine($"The {GetType().Name} stop and made immbilized ");
        }
    }
}
