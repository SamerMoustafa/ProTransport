using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProTransport.Controls
{
    public partial class MainButton : UserControl
    {
        public string Text
        {
            get { return button1.Text; }
            set { button1.Text = value; }
        }
        
        public MainButton()
        {
            InitializeComponent();
        }
    }
}
