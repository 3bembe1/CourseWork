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
    public partial class TicketReturn : Form
    {
        private Ticket TicketForReturn;
        private System.Windows.Forms.ToolTip toolTip1;

        public TicketReturn()
        {
            InitializeComponent();

            toolTip1 = new System.Windows.Forms.ToolTip();
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
        }

        private void textBoxTicketNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxTicketNum.Text))
            {
                MessageBox.Show("Введіть номер квитка.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

            Route route = Program.Routes.FindByNumber(TicketForReturn.RouteNumber);
            string routeInfo = route.ToString();
            
            toolTip1.SetToolTip(this.textBoxRouteNumber, routeInfo);
            toolTip1.SetToolTip(this.textBoxPassengerName, routeInfo);
            toolTip1.SetToolTip(this.textBoxPhoneNumber, routeInfo);
            toolTip1.SetToolTip(this.textBoxStop, routeInfo);

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
