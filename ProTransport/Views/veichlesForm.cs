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
    public partial class veichlesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        List<Veichle> Source;
        public veichlesForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<Veichle>().ToList<Veichle>();
            veichlesGridControl.DataSource = Source;
        }

        public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<Veichle>().ToList<Veichle>();
            veichlesGridControl.DataSource = Source;
            veichlesGridControl.RefreshDataSource();
        }

        private void addVeichlesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new Veichle());
            veichlesGridControl.RefreshDataSource();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {
            
        }

        private void veichlesGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));
            Veichle veichle = (id == 0) ? new Veichle() : Database.Connection.Get<Veichle>(id);

            veichle.Brand = GetString(RowHandler, "Brand");
            veichle.ChaceeId = GetString(RowHandler, "ChaceeId");
            veichle.PlateId = GetString(RowHandler, "PlateId");
            veichle.Type = GetString(RowHandler, "Type");
            veichle.GPS_Serial = GetString(RowHandler, "GPS_Serial");

            if (id == 0) { 
                Database.Connection.Insert<Veichle>(veichle);
                veichlesGridView.SetRowCellValue(RowHandler, "Id", veichle.Id);
            }
            else { Database.Connection.Update<Veichle>(veichle); }
        }

        private String GetString(int handler, String column)
        {
            object obj = veichlesGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void veichleBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void deleteVeichlesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(veichlesGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<Veichle>(new Veichle() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }

        private void veichlesGridControl_Click(object sender, EventArgs e)
        {

        }
    }
}
