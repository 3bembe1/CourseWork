using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CourseWork
{
    public class Route
    {
        [JsonInclude]
        public int Number { get; private set; }

        [JsonInclude]
        public List<string> Stops { get; set; }

        [JsonInclude]
        public DateTime Departure { get; set; }

        [JsonInclude]
        public int Seats { get; private set; }

        public Route(int number, List<string> stops, DateTime departure, int seats)
        {
            Number = number;
            Stops = stops;
            Departure = departure;
            Seats = seats;
        }

        public override string ToString()
        {
            return $"Рейс {Number}: Харків -> {string.Join(" -> ", Stops)} в {Departure}, вільних місць: {Seats}";
        }

        internal class Routes
        {
            private const string FileName = "routes.json";

            [JsonInclude]
            public List<Route> RouteList { get; private set; }
            public Routes()
            {
                RouteList = new List<Route>();
            }

            public void Load()
            {
                string jsonString = File.ReadAllText(FileName);
                RouteList = JsonSerializer.Deserialize<List<Route>>(jsonString);
            }

            public void Save()
            {
                string jsonString = JsonSerializer.Serialize(RouteList);
                File.WriteAllText(FileName, jsonString);
            }

            public List<Route> SearchRoutes(string stop, DateTime from, DateTime to)
            {
                List<Route> result = new List<Route>();

                foreach (var route in RouteList)
                {
                    if (route.Stops.Contains(stop) && route.Departure >= from && route.Departure <= to && route.Seats != 0)
                    {
                        result.Add(route);
                    }
                }
                result.Sort((x, y) => x.Departure.CompareTo(y.Departure));
                return result;
            }

            public Route SearchNearestRoute(string stop)
            {
                Route nearestRoute = null;

                foreach (var route in RouteList)
                {
                    if (route.Stops.Contains(stop) && route.Departure >= DateTime.Now && route.Seats != 0)
                    {
                        if (nearestRoute == null || route.Departure < nearestRoute.Departure)
                        {
                            nearestRoute = route;
                        }
                    }
                }
                return nearestRoute;
            }

            public Route FindByNumber(int number)
            {
                return RouteList.Find(r => r.Number == number);
            }

            public void IncreaseSeats(int routeNumber)
            {
                var route = FindByNumber(routeNumber);

                if (route != null)
                    route.Seats++;
            }

            public void DecreaseSeats(int routeNumber)
            {
                var route = FindByNumber(routeNumber);

                if (route != null)
                    route.Seats--;
            }

            public void Add(Route route)
            {
                RouteList.Add(route);
                RouteList.Sort((x, y) => x.Number.CompareTo(y.Number));
            }
            public void Remove(Route route)
            {
                RouteList.Remove(route);
            }
        }
    }
}
