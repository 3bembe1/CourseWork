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
                Route nearestRoute = Program.SearchNearestRoute(comboBoxStopsList.SelectedItem.ToString());

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
                var route = Program.SearchRoutes(
                    comboBoxStopsList.SelectedItem.ToString(),
                    dateTimePickerFrom.Value,
                    dateTimePickerTo.Value
                );

                if (route.Count > 0)
                {
                    foreach (var r in route)
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

        }

        private void buttonGoToPurchase_Click(object sender, EventArgs e)
        {
            if (listBoxRoutes.SelectedIndex == -1)
            {
                MessageBox.Show("No routes be selected.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                BuyTicketForm buyTicketForm = new BuyTicketForm();
                buyTicketForm.ShowDialog();
            }
        }

    
    }
}
