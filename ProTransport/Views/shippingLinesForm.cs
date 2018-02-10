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
    public partial class shippingLinesForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<ShippingLine> Source;
        public shippingLinesForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<ShippingLine>().ToList<ShippingLine>();
            lineNamesGridControl.DataSource = Source;
        }

        public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<ShippingLine>().ToList<ShippingLine>();
            lineNamesGridControl.DataSource = Source;
            lineNamesGridControl.RefreshDataSource();
        }

        private void addLi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new ShippingLine());
            lineNamesGridControl.RefreshDataSource();
        }

        private void lineNamesGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));
            ShippingLine shippingline = (id == 0) ? new ShippingLine() : Database.Connection.Get<ShippingLine>(id);

            shippingline.Name = GetString(RowHandler, "Name");
            shippingline.Address = GetString(RowHandler, "Address");
            shippingline.Phone = GetString(RowHandler, "Phone");
            shippingline.Mail = GetString(RowHandler, "Mail");
           

            if (id == 0)
            {
                Database.Connection.Insert<ShippingLine>(shippingline);
                lineNamesGridView.SetRowCellValue(RowHandler, "Id", shippingline.Id);
            }
            else { Database.Connection.Update<ShippingLine>(shippingline); }
        }

        private String GetString(int handler, String column)
        {
            object obj = lineNamesGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void lineNamesGridControl_Click(object sender, EventArgs e)
        {

        }

        private void deletLineNamesBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(lineNamesGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<ShippingLine>(new ShippingLine() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }
    }
}
