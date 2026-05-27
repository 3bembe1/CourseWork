namespace CourseWork
{
    internal static class Program
    {
        public static List<string> Stops;
        public static List<Route> Routes;
        public static List<Ticket> Tickets;

        public static List<Route> SearchRoutes(string stop, DateTime from, DateTime to)
        {
            List<Route> result = new List<Route>();
            
            foreach (var route in Routes)
            {
                if (route.Stops.Contains(stop) && route.Departure >= from && route.Departure <= to)
                {
                    result.Add(route);
                }
            }

            return result;
        }

        public static Route SearchNearestRoute(string stop)
        {
            Route nearestRoute = null;

            foreach (var route in Routes)
            {
                if (route.Stops.Contains(stop) && route.Departure >= DateTime.Now)
                {
                    if (nearestRoute == null || route.Departure < nearestRoute.Departure)
                    {
                        nearestRoute = route;
                    }
                }
            }
            return nearestRoute;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Stops = new List<string>();
            Routes = new List<Route>();
            Tickets = new List<Ticket>();

            Stops.Add("Stop1");
            Stops.Add("Stop2");
            Stops.Add("Stop3");
            Stops.Add("Stop4");

            Routes.Add(new Route { Number = 1, Stops = new List<string> { "Stop1", "Stop2" },
                Departure = new DateTime(2026, 6, 1, 8, 0, 0), Seats = 50 });
            Routes.Add(new Route { Number = 2, Stops = new List<string> { "Stop1", "Stop3" },
                Departure = new DateTime(2026, 6, 2, 10, 0, 0), Seats = 40 });

            Application.Run(new Form1());
        }
    }
}