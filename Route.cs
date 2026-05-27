using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    internal class Route
    {
        // TODO: Private fields
        public int Number;
        public List<string> Stops;
        public DateTime Departure;
        public int Seats;
        public override string ToString()
        {
            return $"Route {Number}: {string.Join(" -> ", Stops)} at {Departure}, Seats: {Seats}";
        }
    }
}
