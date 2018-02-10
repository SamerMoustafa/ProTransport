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
        List<Bank> Source;
        public BanksForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<Bank>().ToList<Bank>();
            banksGridControl.DataSource = Source;
        }

             public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<Bank>().ToList<Bank>();
            banksGridControl.DataSource = Source;
            banksGridControl.RefreshDataSource();
        }

        private void addBankBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new Bank());
            banksGridControl.RefreshDataSource();
        }

        private void banksGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));

            Bank bank = (id == 0) ? new Bank() : Database.Connection.Get<Bank>(id);

            bank.Name = GetString(RowHandler, "Name");
            bank.Address = GetString(RowHandler, "Address");
            bank.Phone = GetString(RowHandler, "Phone");
            bank.Mail = GetString(RowHandler, "Mail");
           
         
            if (id == 0)
            {
                Database.Connection.Insert<Bank>(bank);
                banksGridView.SetRowCellValue(RowHandler, "Id", bank.Id);
            }
            else { Database.Connection.Update<Bank>(bank); }
        }
        private String GetString(int handler, String column)
        {
            object obj = banksGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void deleteBankBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(banksGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<Bank>(new Bank() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }

        private void banksGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}