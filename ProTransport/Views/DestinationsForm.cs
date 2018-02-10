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
using ProTransport.Connection;
using ProTransport.Models;

namespace ProTransport.Views
{
    public partial class DestinationsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<Destination> Source;
        public DestinationsForm()
        {
            InitializeComponent();
            //destinationsGridControl.DataSource = Database.Connection.GetAll<Destination>();
            Source = Database.Connection.GetAll<Destination>().ToList<Destination>();
            destinationsGridControl.DataSource = Source;
        }
        public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<Destination>().ToList<Destination>();
            destinationsGridControl.DataSource = Source;
            destinationsGridControl.RefreshDataSource();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void destinationsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));
            Destination destination = (id == 0) ? new Destination() : Database.Connection.Get<Destination>(id);

            destination.Name = GetString(RowHandler, "Name");
            destination.address = GetString(RowHandler, "address");
            destination.Type = GetString(RowHandler, "Type");
           

            if (id == 0)
            {
                Database.Connection.Insert<Destination>(destination);
                destinationsGridView.SetRowCellValue(RowHandler, "Id", destination.Id);
            }
            else { Database.Connection.Update<Destination>(destination); }
        }
        private String GetString(int handler, String column)
        {
            object obj = destinationsGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void addDestinationsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new Destination());
            destinationsGridControl.RefreshDataSource();
        }

        private void deleteDestinationBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(destinationsGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<Destination>(new Destination() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }
    }
}
