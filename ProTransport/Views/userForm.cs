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
    public partial class userForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {      
         List<User> Source;
        public userForm()
        {
            InitializeComponent();
            Source = Database.Connection.GetAll<User>().ToList<User>();
            userGridControl.DataSource = Source;
        }
          public void UpdateDataSourceFromDatabase()
        {
            Source = Database.Connection.GetAll<User>().ToList<User>();
            userGridControl.DataSource = Source;
            userGridControl.RefreshDataSource();
        }
        private void addUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Source.Add(new User());
            userGridControl.RefreshDataSource();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
          private void veichlesGridView_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            int RowHandler = e.RowHandle;
            int id = Convert.ToInt32(GetString(RowHandler, "Id"));
            User user = (id == 0) ? new User() : Database.Connection.Get<User>(id);

            user.Name = GetString(RowHandler, "Name");
            user.Usename = GetString(RowHandler, "Usename");
            user.Paasword = GetString(RowHandler, "Paasword");
            user.Role = GetString(RowHandler, "Role");

            if (id == 0) { 
                Database.Connection.Insert<User>(user);
                userGridView.SetRowCellValue(RowHandler, "Id", user.Id);
            }
            else { Database.Connection.Update<User>(user); }
        }

        private String GetString(int handler, String column)
        {
            object obj = userGridView.GetRowCellValue(handler, column);
            return (obj == null) ? "" : obj.ToString();
        }

        private void deleteUserBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
              int id = Convert.ToInt32(GetString(userGridView.FocusedRowHandle, "Id"));
              if (id > 0)
              {
                  Database.Connection.Delete<User>(new User() { Id = id });
                  UpdateDataSourceFromDatabase();
              }
        }
    }
}
