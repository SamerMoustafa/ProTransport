namespace ProTransport.Views
{
    partial class BanksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanksForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addBankBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteBankBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.banksGridControl = new DevExpress.XtraGrid.GridControl();
            this.bankBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.banksGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addBankBtn,
            this.deleteBankBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(867, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // addBankBtn
            // 
            this.addBankBtn.Caption = "إضافة بنك";
            this.addBankBtn.Id = 1;
            this.addBankBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addBankBtn.ImageOptions.Image")));
            this.addBankBtn.Name = "addBankBtn";
            this.addBankBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.addBankBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addBankBtn_ItemClick);
            // 
            // deleteBankBtn
            // 
            this.deleteBankBtn.Caption = "حذف البنك";
            this.deleteBankBtn.Id = 2;
            this.deleteBankBtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteBankBtn.ImageOptions.Image")));
            this.deleteBankBtn.Name = "deleteBankBtn";
            this.deleteBankBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.deleteBankBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBankBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "البنوك";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addBankBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteBankBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "العمليات";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 428);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(867, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // banksGridControl
            // 
            this.banksGridControl.DataSource = this.bankBindingSource;
            this.banksGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.banksGridControl.Location = new System.Drawing.Point(0, 143);
            this.banksGridControl.MainView = this.banksGridView;
            this.banksGridControl.MenuManager = this.ribbonControl1;
            this.banksGridControl.Name = "banksGridControl";
            this.banksGridControl.Size = new System.Drawing.Size(867, 285);
            this.banksGridControl.TabIndex = 2;
            this.banksGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.banksGridView});
            this.banksGridControl.Click += new System.EventHandler(this.banksGridControl_Click);
            // 
            // bankBindingSource
            // 
            this.bankBindingSource.DataSource = typeof(ProTransport.Models.Bank);
            // 
            // banksGridView
            // 
            this.banksGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colMail});
            this.banksGridView.GridControl = this.banksGridControl;
            this.banksGridView.Name = "banksGridView";
            this.banksGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.banksGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.banksGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.banksGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.banksGridView.OptionsEditForm.PopupEditFormWidth = 500;
            this.banksGridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.banksGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.banksGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.banksGridView_ValidateRow);
            // 
            // colId
            // 
            this.colId.Caption = "الكود";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colName
            // 
            this.colName.Caption = "الإسم";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "العنوان";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 2;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "رقم الهاتف";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colMail
            // 
            this.colMail.Caption = "البريد الإليكترونى";
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 4;
            // 
            // BanksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 459);
            this.Controls.Add(this.banksGridControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BanksForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "BanksForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banksGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem addBankBtn;
        private DevExpress.XtraBars.BarButtonItem deleteBankBtn;
        private DevExpress.XtraGrid.GridControl banksGridControl;
        private System.Windows.Forms.BindingSource bankBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView banksGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
    }
}