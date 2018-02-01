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
    public partial class BanksAccountsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BanksAccountsForm()
        {
            InitializeComponent();
        }

        private void addAccountBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            accountsGridView.AddNewRow();
        }
    }
}
