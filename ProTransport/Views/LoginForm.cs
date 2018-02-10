using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProTransport.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BanksForm s = new BanksForm();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanksAccountsForm d = new BanksAccountsForm();
            d.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientsForm a = new ClientsForm();
            a.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DestinationsForm d = new DestinationsForm();
            d.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            driversForm a = new driversForm();
            a.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            shippingLinesForm r = new shippingLinesForm();
            r.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            userForm s = new userForm();
            s.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            veichlesForm j = new veichlesForm();
            j.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
