using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RoutesEdit : Form
    {
        public RoutesEdit()
        {
            InitializeComponent();

            comboBoxRoutes.DataSource = Program.Routes.RouteList;

            comboBoxRoutes.SelectedIndex = -1;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Route route = Program.Routes.RouteList[comboBoxRoutes.SelectedIndex];
            var tickets = Program.Tickets.GetTicketsByRoute(route.Number);

            if (tickets.Count != 0)
            {
                if (MessageBox.Show("Bla-bla", "aaa", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) != DialogResult.Yes)
                    return;

                foreach (var t in tickets)
                    Program.Tickets.ReturnTicket(t);

                Program.Tickets.Save();
            }

            Program.Routes.Remove(route);

            Program.Routes.Save();

            // Reload comboBox
            comboBoxRoutes.DataSource = null;
            comboBoxRoutes.DataSource = Program.Routes.RouteList;

            comboBoxRoutes.SelectedIndex = -1;
        }

        private void comboBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxRoutes.SelectedIndex != -1)
            {
                buttonRemove.Enabled = true;
                buttonEdit.Enabled = true;
            }
            else
            {
                buttonRemove.Enabled = false;
                buttonEdit.Enabled = false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Route route = Program.Routes.RouteList[comboBoxRoutes.SelectedIndex];
            Route_Edit routeEdit = new Route_Edit(route);
            routeEdit.ShowDialog();

            // Reload comboBox
            comboBoxRoutes.DataSource = null;
            comboBoxRoutes.DataSource = Program.Routes.RouteList;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Route_Edit routeEdit = new Route_Edit(null);
            routeEdit.ShowDialog();

            // Reload comboBox
            comboBoxRoutes.DataSource = null;
            comboBoxRoutes.DataSource = Program.Routes.RouteList;
        }
    }
}
