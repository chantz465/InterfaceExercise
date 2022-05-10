using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public string Year { get; set; }
        public string Color { get; set; }

        public string Model { get; set; }
        public int SeatCount { get; set; }

        public void Drive();
        public void Reverse();
        public void park();



    }
}
