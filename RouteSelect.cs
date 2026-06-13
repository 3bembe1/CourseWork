using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class RouteSelect : Form
    {
        private List<Route> foundRoutes;

        public RouteSelect()
        {
            InitializeComponent();
            comboBoxStopsList.DataSource = Program.Stops;
        }

        private void checkBoxNearestDT_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePickerFrom.Enabled = !checkBoxNearestDT.Checked;
            dateTimePickerTo.Enabled = !checkBoxNearestDT.Checked;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            listBoxRoutes.BeginUpdate();
            listBoxRoutes.Items.Clear();

            if (checkBoxNearestDT.Checked)
            {
                Route nearestRoute = Program.Routes.SearchNearestRoute(comboBoxStopsList.SelectedItem.ToString());

                if (nearestRoute != null)
                {
                    listBoxRoutes.Items.Add(nearestRoute.ToString());
                }
                else
                {
                    MessageBox.Show("No routes found for the selected stop.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                foundRoutes = Program.Routes.SearchRoutes(
                    comboBoxStopsList.SelectedItem.ToString(),
                    dateTimePickerFrom.Value,
                    dateTimePickerTo.Value
                );

                if (foundRoutes.Count > 0)
                {
                    foreach (var r in foundRoutes)
                    {
                        listBoxRoutes.Items.Add(r.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("No routes found for the selected criteria.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            listBoxRoutes.EndUpdate();
        }

        private void listBoxRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonGoToPurchase.Enabled = (listBoxRoutes.SelectedIndex != -1);
        }

        private void buttonGoToPurchase_Click(object sender, EventArgs e)
        {
            if (listBoxRoutes.SelectedIndex != -1)
            {
                Route selectedRoute = foundRoutes[listBoxRoutes.SelectedIndex];
                string stop = comboBoxStopsList.SelectedItem.ToString();
                BuyTicketForm buyTicketForm = new BuyTicketForm(selectedRoute.Number, stop);
                buyTicketForm.ShowDialog();
            }
        }

        private void RouteSelect_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
