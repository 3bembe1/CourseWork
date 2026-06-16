using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Route_Edit : Form
    {
        // If route is null, then add new route, otherwise edit existing route
        public Route_Edit(Route route)
        {
            InitializeComponent();
            
            if (route != null)
            {
                textBoxNumber.Text = route.Number.ToString();
                listBoxStops.DataSource = route.Stops;
                dateTimePickerDepart.Value = route.Departure;
                textBoxSeats.Text = route.Seats.ToString();
            }
            else
            {
                // Add new route
            }
        }
    }
}
