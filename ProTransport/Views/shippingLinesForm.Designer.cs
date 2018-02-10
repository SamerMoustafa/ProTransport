namespace ProTransport.Views
{
    partial class shippingLinesForm
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
            this.addLineNamesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deletLineNamesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.lineNamesGridControl = new DevExpress.XtraGrid.GridControl();
            this.shippingLineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lineNamesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMail = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNamesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingLineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNamesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addLineNamesBtn,
            this.deletLineNamesBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(920, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // addLineNamesBtn
            // 
            this.addLineNamesBtn.Caption = "اضافه اسم خط ملاحى";
            this.addLineNamesBtn.Id = 1;
            this.addLineNamesBtn.Name = "addLineNamesBtn";
            this.addLineNamesBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addLi_ItemClick);
            // 
            // deletLineNamesBtn
            // 
            this.deletLineNamesBtn.Caption = "الحذف";
            this.deletLineNamesBtn.Id = 2;
            this.deletLineNamesBtn.Name = "deletLineNamesBtn";
            this.deletLineNamesBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deletLineNamesBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "الخطوط الملاحيه";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addLineNamesBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deletLineNamesBtn);
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
            this.ribbonStatusBar1.Size = new System.Drawing.Size(920, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // lineNamesGridControl
            // 
            this.lineNamesGridControl.DataSource = this.shippingLineBindingSource;
            this.lineNamesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lineNamesGridControl.Location = new System.Drawing.Point(0, 143);
            this.lineNamesGridControl.MainView = this.lineNamesGridView;
            this.lineNamesGridControl.MenuManager = this.ribbonControl1;
            this.lineNamesGridControl.Name = "lineNamesGridControl";
            this.lineNamesGridControl.Size = new System.Drawing.Size(920, 320);
            this.lineNamesGridControl.TabIndex = 2;
            this.lineNamesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.lineNamesGridView});
            this.lineNamesGridControl.Click += new System.EventHandler(this.lineNamesGridControl_Click);
            // 
            // shippingLineBindingSource
            // 
            this.shippingLineBindingSource.DataSource = typeof(ProTransport.Models.ShippingLine);
            // 
            // lineNamesGridView
            // 
            this.lineNamesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colAddress,
            this.colPhone,
            this.colMail});
            this.lineNamesGridView.GridControl = this.lineNamesGridControl;
            this.lineNamesGridView.Name = "lineNamesGridView";
            this.lineNamesGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.lineNamesGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.lineNamesGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.lineNamesGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.lineNamesGridView.OptionsEditForm.PopupEditFormWidth = 500;
            this.lineNamesGridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.lineNamesGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.lineNamesGridView_ValidateRow);
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
            // colPhone
            // 
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 3;
            // 
            // colMail
            // 
            this.colMail.FieldName = "Mail";
            this.colMail.Name = "colMail";
            this.colMail.Visible = true;
            this.colMail.VisibleIndex = 4;
            // 
            // shippingLinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 494);
            this.Controls.Add(this.lineNamesGridControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "shippingLinesForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "shippingLinesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNamesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shippingLineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lineNamesGridView)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem addLineNamesBtn;
        private DevExpress.XtraBars.BarButtonItem deletLineNamesBtn;
        private DevExpress.XtraGrid.GridControl lineNamesGridControl;
        private System.Windows.Forms.BindingSource shippingLineBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView lineNamesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colMail;
    }
}