using System.Text.Json;

namespace CourseWork
{
    internal static class Program
    {
        public static List<string> Stops = new List<string>();
        public static Ticket.Tickets Tickets = new Ticket.Tickets();
        public static Route.Routes Routes = new Route.Routes();

        

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string jsonString = File.ReadAllText("stops.json");
            Stops = JsonSerializer.Deserialize<List<string>>(jsonString);

            Routes.Load();
            Tickets.Load();

            Application.Run(new Form1());
        }
    }
}