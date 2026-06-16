namespace CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RouteSelect routeSelect = new RouteSelect();
            routeSelect.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TicketReturn ticketReturn = new TicketReturn();
            ticketReturn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boarding boarding = new Boarding();
            boarding.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RoutesEdit routesEdit = new RoutesEdit();
            routesEdit.ShowDialog();
        }
    }
}
