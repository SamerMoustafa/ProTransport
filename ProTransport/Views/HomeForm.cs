using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ProTransport.Views
{
    public partial class HomeForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public HomeForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            this.documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddDriverForm form = new AddDriverForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}