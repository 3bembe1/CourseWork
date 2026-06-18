using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
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

            buttonFile.Enabled = listBoxTickets.Items.Count > 0;
        }

        private void Boarding_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Зберегти файл",
                FileName = "Untitled"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(saveFileDialog.FileName, listBoxTickets.Items.Cast<object>().Select(x => x.ToString()));
            }
        }
    }
}
