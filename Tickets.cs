using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    internal class Ticket
    {
        [JsonInclude]
        private int Number;
        
        [JsonInclude]
        public string PassengerName { get; private set; }
        
        [JsonInclude]
        public string PhoneNumber { get; private set; }

        [JsonInclude]
        public int RouteNumber { get; private set; }

        [JsonInclude]
        public string Stop { get; private set; }
        public Ticket (int number, string passengerName, string phoneNumber, int routeNumber, string stop)
        {
            Number = number;
            PassengerName = passengerName;
            PhoneNumber = phoneNumber;
            RouteNumber = routeNumber;
            Stop = stop;
        }

        internal class Tickets
        {
            private const string FileName = "tickets.json";

            [JsonInclude]
            private List<Ticket> TicketList;
            public Tickets()
            {
                TicketList = new List<Ticket>();
            }

            private int nextTicketNumber = 1;

            public void Load()
            {
                string jsonString = File.ReadAllText(FileName);
                TicketList = JsonSerializer.Deserialize<List<Ticket>>(jsonString);
            }

            public void Save()
            {
                string jsonString = JsonSerializer.Serialize(TicketList);
                File.WriteAllText(FileName, jsonString);
            }

            public void BuyTicket(int routeNumber, string stop, string passengerName, string phoneNumber)
            {
                TicketList.Add(new Ticket(nextTicketNumber++, passengerName, phoneNumber, routeNumber, stop));
                Program.Routes.DecreaseSeats(routeNumber);
            }

            public Ticket SearchTicket(int ticketNumber)
            {
                foreach (var ticket in TicketList)
                {
                    if (ticket.Number == ticketNumber)
                    {
                        return ticket;
                    }
                }
                return null;
            }

            public void ReturnTicket(Ticket ticket)
            {
                if (ticket != null)
                {
                    Program.Routes.IncreaseSeats(ticket.RouteNumber);
                    TicketList.Remove(ticket);
                }
            }

            private void GetNextTicketNumber()
            {
                foreach (var ticket in TicketList)
                {
                    if (ticket.Number >= nextTicketNumber)
                    {
                        nextTicketNumber = ticket.Number + 1;
                    }
                }
            }
        }
    }
}
