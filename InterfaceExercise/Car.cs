using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle, ICompany
    {
        public Car()
        {

        }

        public string CompanyName { get; set; } = "Audi";
        public string Logo { get; set; } = "four rings";
        string IVehicle.Year { get; set; } = "1999";
        string IVehicle.Color { get; set; } = "Black";
        string IVehicle.Model { get; set; } = "A4";
        int IVehicle.SeatCount { get; set; } = 5;

        public bool HasTrunk { get; set; } = true;


        public void Drive()
        {
            Console.WriteLine($"The {GetType().Name} now going forword");
        }
        public void Reverse()
        {
            Console.WriteLine($"The {GetType().Name} now going backwards");
        }
        public void park()
        {
            Console.WriteLine($"The {GetType().Name} stop and made immbilized ");

            if (HasTrunk == true)
            {
                Console.WriteLine("popped the trunk");
            }
            else
            {
            }
        }

    }
}
