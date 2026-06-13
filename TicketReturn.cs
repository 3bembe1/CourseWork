using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class TicketReturn : Form
    {
        private Ticket TicketForReturn;

        public TicketReturn()
        {
            InitializeComponent();
        }

        private void textBoxTicketNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows digits (0-9) and control keys like Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject the input
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            TicketForReturn = Program.Tickets.SearchTicket(int.Parse(textBoxTicketNum.Text));

            if (TicketForReturn == null)
            {
                MessageBox.Show("Квиток не знайдено.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            textBoxPassengerName.Text = TicketForReturn.PassengerName;
            textBoxPhoneNumber.Text = TicketForReturn.PhoneNumber;
            textBoxRouteNumber.Text = TicketForReturn.RouteNumber.ToString();
            textBoxStop.Text = TicketForReturn.Stop;

            ToolTip toolTip1 = new ToolTip();

            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            Route route = Program.Routes.FindByNumber(TicketForReturn.RouteNumber);
            toolTip1.SetToolTip(this.textBoxRouteNumber, route.ToString());

            buttonTicketReturn.Enabled = true;
        }

        private void buttonTicketReturn_Click(object sender, EventArgs e)
        {
            Program.Tickets.ReturnTicket(TicketForReturn);
            MessageBox.Show("Квиток успішно повернено.", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Program.Tickets.Save();
            Program.Routes.Save();

            this.Close();
        }

        private void TicketReturn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
