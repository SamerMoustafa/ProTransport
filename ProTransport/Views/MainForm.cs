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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            clientsStartBtn.Text = toursStartBtn.Text = driversStartBtn.Text = usersStartBtn.Text = banksStartBtn.Text = accountingStartBtn.Text = "Start Now";
            logoutBtn.Text = "Sign Out";
            usernameLabel.Text = "Sameh";
            dateLabel.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void minimizeBtn_Click(object sender, EventArgs e)
        {

        }
        

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
