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
    public partial class driversForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<Driver> Source;
        public driversForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<Driver>().ToList<Driver>();
            driversGridControl.DataSource = Source;
        }
        public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<Driver>().ToList<Driver>();
            driversGridControl.DataSource = Source;
            driversGridControl.RefreshDataSource();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new Driver());
            driversGridControl.RefreshDataSource();
        }

        private void drieversGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));

            Driver driver = (id == 0) ? new Driver() : Database.Connection.Get<Driver>(id);

            driver.Name = GetString(RowHandler, "Name");
            driver.Salary = Convert.ToInt32(GetString(RowHandler, "Salary"));
            driver.Phone = GetString(RowHandler, "Phone");
            driver.Address = GetString(RowHandler, "Address");
            driver.Locked = Convert.ToInt32(GetString(RowHandler, "Locked"));
            driver.FavouriteCar = Convert.ToInt32(GetString(RowHandler, "FavouriteCar"));
            driver.IdNo = GetString(RowHandler, "IdNo");

            if (id == 0)
            {
                Database.Connection.Insert<Driver>(driver);
                drieversGridView.SetRowCellValue(RowHandler, "Id", driver.Id);
            }
            else { Database.Connection.Update<Driver>(driver); }
        }

        private String GetString(int handler, String column)
        {
            object obj = drieversGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void deleteDriverBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(drieversGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<Driver>(new Driver() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }
    }
}
