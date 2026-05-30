using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CourseWork
{
    internal partial class BuyTicketForm : Form
    {
        private Route _Route;
        private string _Stop;

        public BuyTicketForm(Route route, string stop)
        {
            InitializeComponent();
            this._Route = route;
            this._Stop = stop;
        }

        public bool IsValidFullName(string fullName)
        {
            string pattern = @"^[А-ЯІЇЄҐа-яіїєґ']+(?:-[А-ЯІЇЄҐа-яіїєґ']+)* [А-ЯІЇЄҐа-яіїєґ']+(?:-[А-ЯІЇЄҐа-яіїєґ']+)* [А-ЯІЇЄҐа-яіїєґ']+(?:-[А-ЯІЇЄҐа-яіїєґ']+)*$";
            //
            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            return Regex.IsMatch(fullName, pattern);
        }

        public bool IsValidPhoneNumber(string phoneNumber)
        {
            string pattern = @"^\+380\d{9}$";
            //
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;

            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null || textBox1.Text == "")
            {
                MessageBox.Show("Будь ласка, заповніть ПІБ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidFullName(textBox1.Text))
            {
                MessageBox.Show("Будь ласка, перевірьте ПІБ.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == null || textBox2.Text == "")
            {
                MessageBox.Show("Будь ласка, заповніть номер телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidPhoneNumber(textBox2.Text))
            {
                MessageBox.Show("Будь ласка, перевірьте номер телефону.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.Focus();
                return;
            }

            Program.BuyTicket(_Route, _Stop, textBox1.Text, textBox2.Text);

            //TODO: Виводити інформацію про маршрут та зупинку, для якої купується квиток в messageBox
            MessageBox.Show("Квиток успішно куплено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }  
    }
}
