using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWork
{
    internal class Ticket
    {
        // TODO: Private fields
        public int Number;
        public string PassengerName;
        public string PhoneNumber;
        public int RouteNumber;
        public string Stop;

        public Ticket (int number, string passengerName, string phoneNumber, int routeNumber, string stop)
        {
            Number = number;
            PassengerName = passengerName;
            PhoneNumber = phoneNumber;
            RouteNumber = routeNumber;
            Stop = stop;
        }
    }
}
