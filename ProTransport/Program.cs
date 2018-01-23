using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProTransport.Views;
using ProTransport.Connection;

namespace ProTransport
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            //Change
            Database.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
