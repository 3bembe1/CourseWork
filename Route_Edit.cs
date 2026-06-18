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
        private Route Route;
        private List<string> StopsTmp;

        // If route is null, then add new route, otherwise edit existing route
        public Route_Edit(Route route)
        {
            InitializeComponent();

            Route = route;
            dateTimePickerDepart.MinDate = DateTime.Now;

            if (route != null)
            {
                textBoxNumber.Text = route.Number.ToString();
                textBoxNumber.ReadOnly = true;
                StopsTmp = route.Stops;
                listBoxStops.DataSource = StopsTmp;
                dateTimePickerDepart.Value = route.Departure;
                textBoxSeats.Text = route.Seats.ToString();
                textBoxSeats.ReadOnly = true;
            }
            else
            {
                StopsTmp = new List<string>();
                dateTimePickerDepart.Value = DateTime.Now;
            }

            comboBoxStops.DataSource = Program.Stops;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Route != null)
            {
                Route.Stops = StopsTmp;
                Route.Departure = dateTimePickerDepart.Value;
            }
            else
            {
                if (textBoxNumber.Text == "" || int.Parse(textBoxNumber.Text) == 0 ||
                    textBoxSeats.Text == "" || int.Parse(textBoxSeats.Text) == 0)
                {
                    MessageBox.Show("Перевірьте введені дані", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Program.Routes.Add(new Route(int.Parse(textBoxNumber.Text), StopsTmp,
                    dateTimePickerDepart.Value, int.Parse(textBoxSeats.Text)));
            }

            Program.Routes.Save();
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var stop = comboBoxStops.SelectedItem.ToString();

            if (StopsTmp.Exists(s => s == stop))
                return;

            StopsTmp.Insert(listBoxStops.SelectedIndex + 1, stop);

            listBoxStops.DataSource = null;
            listBoxStops.DataSource = StopsTmp;

            //listBoxStops.SelectedIndex++;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (StopsTmp.Count <= 1)
                return;

            StopsTmp.RemoveAt(listBoxStops.SelectedIndex);

            listBoxStops.DataSource = null;
            listBoxStops.DataSource = StopsTmp;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            int i = listBoxStops.SelectedIndex;

            if (i <= 0)
                return;

            (StopsTmp[i - 1], StopsTmp[i]) = (StopsTmp[i], StopsTmp[i - 1]);

            listBoxStops.DataSource = null;
            listBoxStops.DataSource = StopsTmp;

            listBoxStops.SelectedIndex--;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            int i = listBoxStops.SelectedIndex;

            if (i == StopsTmp.Count - 1)
                return;

            (StopsTmp[i + 1], StopsTmp[i]) = (StopsTmp[i], StopsTmp[i + 1]);

            listBoxStops.DataSource = null;
            listBoxStops.DataSource = StopsTmp;

            listBoxStops.SelectedIndex++;
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxNumber_Leave(object sender, EventArgs e)
        {
            if (Route == null &&
                textBoxNumber.Text != "" &&
                Program.Routes.RouteList.Exists(r => r.Number == int.Parse(textBoxNumber.Text)))
            {
                MessageBox.Show("Такий рейс вже існує", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxNumber.Text = "";
            }
        }
    }
}
