using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Suv : IVehicle, ICompany
    {
        public string CompanyName { get; set; } = "Ford";
        public string Logo { get; set; } = "WHite Horse";
        string IVehicle.Year { get; set; } = "1996";
        string IVehicle.Color { get; set; } = "Tan";
        string IVehicle.Model { get; set; } = "Branco";
        int IVehicle.SeatCount { get; set; } = 2;

        public bool FourWheelDrive { get; set; } = true;

       
        
       

        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} now going forword");
            if (FourWheelDrive == true)
            {
                Console.WriteLine("In four wheel drive");
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
