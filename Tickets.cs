using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
        public Ticket(int number, string passengerName, string phoneNumber, int routeNumber, string stop)
        {
            Number = number;
            PassengerName = passengerName;
            PhoneNumber = phoneNumber;
            RouteNumber = routeNumber;
            Stop = stop;
        }

        public override string ToString()
        {
            return $"Квиток {Number,-6} | {PassengerName,-30} | {PhoneNumber,-13} | Маршрут: {RouteNumber,-6} | Зупинка: {Stop,-12}";
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

            [JsonInclude]
            private int nextTicketNumber = 1;

            public void Load()
            {
                string jsonString = File.ReadAllText(FileName);
                Tickets tickets = JsonSerializer.Deserialize<Tickets>(jsonString);
                
                if (tickets != null)
                {
                    TicketList = tickets.TicketList;
                    nextTicketNumber = tickets.nextTicketNumber;
                }
            }

            public void Save()
            {
                string jsonString = JsonSerializer.Serialize(this);
                File.WriteAllText(FileName, jsonString);
            }

            public int BuyTicket(int routeNumber, string stop, string passengerName, string phoneNumber)
            {
                Ticket ticket = new Ticket(nextTicketNumber++, passengerName, phoneNumber, routeNumber, stop);
                TicketList.Add(ticket);
                Program.Routes.DecreaseSeats(routeNumber);
                return ticket.Number;
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

            public List<Ticket> GetTicketsByRoute(int RouteNumber)
            {
                return TicketList.FindAll(t => t.RouteNumber == RouteNumber);
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
