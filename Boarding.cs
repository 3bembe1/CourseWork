using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CourseWork
{
    public partial class Boarding : Form
    {
        public Boarding()
        {
            InitializeComponent();

            comboBoxRoutes.DataSource = Program.Routes.RouteList;

            comboBoxRoutes.SelectedIndex = -1;
        }

        private void comboBoxRoutes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Route route = Program.Routes.RouteList[comboBoxRoutes.SelectedIndex];
            var tickets = Program.Tickets.GetTicketsByRoute(route.Number);

            listBoxTickets.BeginUpdate();
            listBoxTickets.Items.Clear();

            foreach (var t in tickets)
            {
                listBoxTickets.Items.Add(t.ToString());
            }

            listBoxTickets.EndUpdate();
        }

        private void Boarding_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
