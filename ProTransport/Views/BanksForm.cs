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
using ProTransport.Connection;
using Dapper.Contrib.Extensions;
using ProTransport.Models;

namespace ProTransport.Views
{
    public partial class BanksForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public BanksForm()
        {
            InitializeComponent();
            banksGridControl.DataSource = Database.Connection.GetAll<Bank>();
        }

        private void addBankBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            banksGridView.AddNewRow();
        }

        private void banksGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            MessageBox.Show("Validate");
        }
    }
}