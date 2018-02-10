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
    public partial class ClientsForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        List<Client> Source;
        public ClientsForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<Client>().ToList<Client>();
            clientsGridControl.DataSource = Source;
        }

        public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<Client>().ToList<Client>();
            clientsGridControl.DataSource = Source;
            clientsGridControl.RefreshDataSource();
        }

        private void addClientsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new Client());
            clientsGridControl.RefreshDataSource();
        }

        private void clientsGridControl_Click(object sender, EventArgs e)
        {

        }

        private void clientsGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));

            Client client = (id == 0) ? new Client() : Database.Connection.Get<Client>(id);

            client.Name = GetString(RowHandler, "Name");
            client.Address = GetString(RowHandler, "Address");
            client.CompanyPhone = GetString(RowHandler, "CompanyPhone");
            client.Address = GetString(RowHandler, "Address");
            client.CompanyMail = GetString(RowHandler, "CompanyMail");
            client.AccountantPhone = GetString(RowHandler, "AccountantPhone");
            client.AccountantMail = GetString(RowHandler, "AccountantMail");

            if (id == 0)
            {
                Database.Connection.Insert<Client>(client);
                clientsGridView.SetRowCellValue(RowHandler, "Id", client.Id);
            }
            else { Database.Connection.Update<Client>(client); }
             }

        private String GetString(int handler, String column)
        {
            object obj = clientsGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void deleteClientsBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(GetString(clientsGridView.FocusedRowHandle, "Id"));
            if (id > 0)
            {
                Database.Connection.Delete<Client>(new Client() { Id = id });
                UpdateDataSourceFromDatabase();
            }
        }
        
    }
}
