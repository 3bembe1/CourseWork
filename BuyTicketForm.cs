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
    public partial class BuyTicketForm : Form
    {
        public BuyTicketForm()
        {
            InitializeComponent();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

            MessageBox.Show("Квиток успішно куплено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        //TODO: «Номер рейсу» – інформаційне поле, яке автоматично заповнюється номером обраного рейсу та заблоковане для редагування.
        // В MessageBox писати номер квитка, який купив користувач та повну назву маршруту, який він вибрав. (Наприклад: «Ви купили квиток №123 на маршрут Stop1 - Stop2»).
    }
}
