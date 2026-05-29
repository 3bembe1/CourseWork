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
            return $"Рейс {Number}: {string.Join(" -> ", Stops)} в {Departure}, вільних місць: {Seats}";
        }
    }
}
