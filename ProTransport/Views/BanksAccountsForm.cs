using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper.Contrib.Extensions;
using ProTransport.Models;
using ProTransport.Connection;

namespace ProTransport.Views
{
    public partial class BanksAccountsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<BankAccount> Source;
        public BanksAccountsForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<BankAccount>().ToList<BankAccount>();
            accountsGridControl.DataSource = Source;
        }

        public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<BankAccount>().ToList<BankAccount>();
            accountsGridControl.DataSource = Source;
            accountsGridControl.RefreshDataSource();
        }

        private void addAccountBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new BankAccount());
            accountsGridControl.RefreshDataSource();
        }

        private void accountsGridControl_Click(object sender, EventArgs e)
        {

        }

        private void accountsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));

            BankAccount bankaccouning = (id == 0) ? new BankAccount() : Database.Connection.Get<BankAccount>(id);

            bankaccouning.BankId = Convert.ToInt32(GetString(RowHandler, "BankId"));
            bankaccouning.Holder = GetString(RowHandler, "Holder");
            bankaccouning.Le = GetString(RowHandler, "Le");
            bankaccouning.Usd = GetString(RowHandler, "Usd");
            bankaccouning.Euro = GetString(RowHandler, "Euro");


            if (id == 0)
            {
                Database.Connection.Insert<BankAccount>(bankaccouning);
                accountsGridView.SetRowCellValue(RowHandler, "Id", bankaccouning.Id);
            }
            else { Database.Connection.Update<BankAccount>(bankaccouning); }
        }

        private String GetString(int handler, String column)
        {
            object obj = accountsGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

      

        private void deleteAccountBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(accountsGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<BankAccount>(new BankAccount() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }
    }
}
