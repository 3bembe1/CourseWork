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

            if (string.IsNullOrWhiteSpace(fullName))
                return false;

            return Regex.IsMatch(fullName, pattern);
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
        }
    }
}
