namespace ProTransport.Views
{
    partial class veichlesForm
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
            this.addVeichlesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteVeichlesBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.veichlesGridControl = new DevExpress.XtraGrid.GridControl();
            this.veichleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veichlesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBrand = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChaceeId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGPS_Serial = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addVeichlesBtn,
            this.deleteVeichlesBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonControl1.Size = new System.Drawing.Size(939, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // addVeichlesBtn
            // 
            this.addVeichlesBtn.Caption = "اضافه بيان سيارة";
            this.addVeichlesBtn.Id = 1;
            this.addVeichlesBtn.Name = "addVeichlesBtn";
            this.addVeichlesBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addVeichlesBtn_ItemClick);
            // 
            // deleteVeichlesBtn
            // 
            this.deleteVeichlesBtn.Caption = "حذف بيان";
            this.deleteVeichlesBtn.Id = 2;
            this.deleteVeichlesBtn.Name = "deleteVeichlesBtn";
            this.deleteVeichlesBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteVeichlesBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "السيارات";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addVeichlesBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteVeichlesBtn);
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
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 450);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(939, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // veichlesGridControl
            // 
            this.veichlesGridControl.DataSource = this.veichleBindingSource;
            this.veichlesGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.veichlesGridControl.Location = new System.Drawing.Point(0, 143);
            this.veichlesGridControl.MainView = this.veichlesGridView;
            this.veichlesGridControl.MenuManager = this.ribbonControl1;
            this.veichlesGridControl.Name = "veichlesGridControl";
            this.veichlesGridControl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.veichlesGridControl.Size = new System.Drawing.Size(939, 307);
            this.veichlesGridControl.TabIndex = 2;
            this.veichlesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.veichlesGridView});
            this.veichlesGridControl.Click += new System.EventHandler(this.veichlesGridControl_Click);
            // 
            // veichleBindingSource
            // 
            this.veichleBindingSource.DataSource = typeof(ProTransport.Models.Veichle);
            this.veichleBindingSource.CurrentChanged += new System.EventHandler(this.veichleBindingSource_CurrentChanged);
            // 
            // veichlesGridView
            // 
            this.veichlesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colBrand,
            this.colType,
            this.colChaceeId,
            this.colPlateId,
            this.colGPS_Serial});
            this.veichlesGridView.GridControl = this.veichlesGridControl;
            this.veichlesGridView.Name = "veichlesGridView";
            this.veichlesGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.veichlesGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.veichlesGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.veichlesGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.veichlesGridView.OptionsEditForm.PopupEditFormWidth = 500;
            this.veichlesGridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.veichlesGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.veichlesGridView_ValidateRow);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colBrand
            // 
            this.colBrand.FieldName = "Brand";
            this.colBrand.Name = "colBrand";
            this.colBrand.Visible = true;
            this.colBrand.VisibleIndex = 0;
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 1;
            // 
            // colChaceeId
            // 
            this.colChaceeId.FieldName = "ChaceeId";
            this.colChaceeId.Name = "colChaceeId";
            this.colChaceeId.Visible = true;
            this.colChaceeId.VisibleIndex = 2;
            // 
            // colPlateId
            // 
            this.colPlateId.FieldName = "PlateId";
            this.colPlateId.Name = "colPlateId";
            this.colPlateId.Visible = true;
            this.colPlateId.VisibleIndex = 3;
            // 
            // colGPS_Serial
            // 
            this.colGPS_Serial.FieldName = "GPS_Serial";
            this.colGPS_Serial.Name = "colGPS_Serial";
            this.colGPS_Serial.Visible = true;
            this.colGPS_Serial.VisibleIndex = 4;
            // 
            // veichlesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 481);
            this.Controls.Add(this.veichlesGridControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "veichlesForm";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "veichlesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veichlesGridView)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem addVeichlesBtn;
        private DevExpress.XtraBars.BarButtonItem deleteVeichlesBtn;
        private DevExpress.XtraGrid.GridControl veichlesGridControl;
        private System.Windows.Forms.BindingSource veichleBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView veichlesGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colBrand;
        private DevExpress.XtraGrid.Columns.GridColumn colType;
        private DevExpress.XtraGrid.Columns.GridColumn colChaceeId;
        private DevExpress.XtraGrid.Columns.GridColumn colPlateId;
        private DevExpress.XtraGrid.Columns.GridColumn colGPS_Serial;
    }
}