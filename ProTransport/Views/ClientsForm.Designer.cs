namespace ProTransport.Views
{
    partial class ClientsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addClientsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteClientsBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.clientsGridControl = new DevExpress.XtraGrid.GridControl();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompanyMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountantPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountantMail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addClientsBtn,
            this.deleteClientsBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1022, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // addClientsBtn
            // 
            this.addClientsBtn.Caption = "اضافه اسم عميل";
            this.addClientsBtn.Id = 1;
            this.addClientsBtn.Name = "addClientsBtn";
            this.addClientsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addClientsBtn_ItemClick);
            // 
            // deleteClientsBtn
            // 
            this.deleteClientsBtn.Caption = "حذف اسم عميل ";
            this.deleteClientsBtn.Id = 2;
            this.deleteClientsBtn.Name = "deleteClientsBtn";
            this.deleteClientsBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteClientsBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "اسماء العملاء";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addClientsBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteClientsBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 463);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1022, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // clientsGridControl
            // 
            this.clientsGridControl.DataSource = this.clientBindingSource;
            this.clientsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientsGridControl.Location = new System.Drawing.Point(0, 143);
            this.clientsGridControl.MainView = this.clientsGridView;
            this.clientsGridControl.MenuManager = this.ribbonControl1;
            this.clientsGridControl.Name = "clientsGridControl";
            this.clientsGridControl.Size = new System.Drawing.Size(1022, 320);
            this.clientsGridControl.TabIndex = 2;
            this.clientsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.clientsGridView});
            this.clientsGridControl.Click += new System.EventHandler(this.clientsGridControl_Click);
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataSource = typeof(ProTransport.Models.Client);
            // 
            // clientsGridView
            // 
            this.clientsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colAddress,
            this.colCompanyPhone,
            this.colCompanyMail,
            this.colAccountantPhone,
            this.colAccountantMail});
            this.clientsGridView.GridControl = this.clientsGridControl;
            this.clientsGridView.Name = "clientsGridView";
            this.clientsGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.clientsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.clientsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.clientsGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.clientsGridView.OptionsEditForm.PopupEditFormWidth = 500;
            this.clientsGridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.clientsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.clientsGridView_ValidateRow);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colCompanyPhone
            // 
            this.colCompanyPhone.FieldName = "CompanyPhone";
            this.colCompanyPhone.Name = "colCompanyPhone";
            this.colCompanyPhone.Visible = true;
            this.colCompanyPhone.VisibleIndex = 3;
            // 
            // colCompanyMail
            // 
            this.colCompanyMail.FieldName = "CompanyMail";
            this.colCompanyMail.Name = "colCompanyMail";
            this.colCompanyMail.Visible = true;
            this.colCompanyMail.VisibleIndex = 4;
            // 
            // colAccountantPhone
            // 
            this.colAccountantPhone.FieldName = "AccountantPhone";
            this.colAccountantPhone.Name = "colAccountantPhone";
            this.colAccountantPhone.Visible = true;
            this.colAccountantPhone.VisibleIndex = 5;
            // 
            // colAccountantMail
            // 
            this.colAccountantMail.FieldName = "AccountantMail";
            this.colAccountantMail.Name = "colAccountantMail";
            this.colAccountantMail.Visible = true;
            this.colAccountantMail.VisibleIndex = 6;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 494);
            this.Controls.Add(this.clientsGridControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "ClientsForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ClientsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem addClientsBtn;
        private DevExpress.XtraBars.BarButtonItem deleteClientsBtn;
        private DevExpress.XtraGrid.GridControl clientsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView clientsGridView;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colCompanyMail;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountantPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountantMail;
    }
}