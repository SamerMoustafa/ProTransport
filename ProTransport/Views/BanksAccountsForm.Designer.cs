namespace ProTransport.Views
{
    partial class BanksAccountsForm
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
            this.addAccountBtn = new DevExpress.XtraBars.BarButtonItem();
            this.deleteAccountBtn = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.accountsGridControl = new DevExpress.XtraGrid.GridControl();
            this.bankAccountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBankId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHolder = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUsd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEuro = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.addAccountBtn,
            this.deleteAccountBtn});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1041, 143);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // addAccountBtn
            // 
            this.addAccountBtn.Caption = "اضافه رقم حساب بنكى";
            this.addAccountBtn.Id = 1;
            this.addAccountBtn.Name = "addAccountBtn";
            this.addAccountBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.addAccountBtn_ItemClick);
            // 
            // deleteAccountBtn
            // 
            this.deleteAccountBtn.Caption = "حذف رقم حساب بنكى";
            this.deleteAccountBtn.Id = 2;
            this.deleteAccountBtn.Name = "deleteAccountBtn";
            this.deleteAccountBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteAccountBtn_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ارقام حسابات البنوك";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.addAccountBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.deleteAccountBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "العمليات ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 460);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1041, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // accountsGridControl
            // 
            this.accountsGridControl.DataSource = this.bankAccountBindingSource;
            this.accountsGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountsGridControl.Location = new System.Drawing.Point(0, 143);
            this.accountsGridControl.MainView = this.accountsGridView;
            this.accountsGridControl.MenuManager = this.ribbonControl1;
            this.accountsGridControl.Name = "accountsGridControl";
            this.accountsGridControl.Size = new System.Drawing.Size(1041, 317);
            this.accountsGridControl.TabIndex = 2;
            this.accountsGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.accountsGridView});
            this.accountsGridControl.Click += new System.EventHandler(this.accountsGridControl_Click);
            // 
            // bankAccountBindingSource
            // 
            this.bankAccountBindingSource.DataSource = typeof(ProTransport.Models.BankAccount);
            // 
            // accountsGridView
            // 
            this.accountsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colBankId,
            this.colHolder,
            this.colLe,
            this.colUsd,
            this.colEuro});
            this.accountsGridView.GridControl = this.accountsGridControl;
            this.accountsGridView.Name = "accountsGridView";
            this.accountsGridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.accountsGridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
            this.accountsGridView.OptionsBehavior.AllowPartialRedrawOnScrolling = false;
            this.accountsGridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.accountsGridView.OptionsBehavior.SmartVertScrollBar = false;
            this.accountsGridView.OptionsEditForm.EditFormColumnCount = 2;
            this.accountsGridView.OptionsEditForm.PopupEditFormWidth = 500;
            this.accountsGridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.True;
            this.accountsGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.accountsGridView_ValidateRow);
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // colBankId
            // 
            this.colBankId.FieldName = "BankId";
            this.colBankId.Name = "colBankId";
            this.colBankId.Visible = true;
            this.colBankId.VisibleIndex = 1;
            // 
            // colHolder
            // 
            this.colHolder.FieldName = "Holder";
            this.colHolder.Name = "colHolder";
            this.colHolder.Visible = true;
            this.colHolder.VisibleIndex = 2;
            // 
            // colLe
            // 
            this.colLe.FieldName = "Le";
            this.colLe.Name = "colLe";
            this.colLe.Visible = true;
            this.colLe.VisibleIndex = 3;
            // 
            // colUsd
            // 
            this.colUsd.FieldName = "Usd";
            this.colUsd.Name = "colUsd";
            this.colUsd.Visible = true;
            this.colUsd.VisibleIndex = 4;
            // 
            // colEuro
            // 
            this.colEuro.FieldName = "Euro";
            this.colEuro.Name = "colEuro";
            this.colEuro.Visible = true;
            this.colEuro.VisibleIndex = 5;
            // 
            // BanksAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 491);
            this.Controls.Add(this.accountsGridControl);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "BanksAccountsForm";
            this.Ribbon = this.ribbonControl1;
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "BanksAccountsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankAccountBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountsGridView)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem addAccountBtn;
        private DevExpress.XtraBars.BarButtonItem deleteAccountBtn;
        private DevExpress.XtraGrid.GridControl accountsGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView accountsGridView;
        private System.Windows.Forms.BindingSource bankAccountBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colBankId;
        private DevExpress.XtraGrid.Columns.GridColumn colHolder;
        private DevExpress.XtraGrid.Columns.GridColumn colLe;
        private DevExpress.XtraGrid.Columns.GridColumn colUsd;
        private DevExpress.XtraGrid.Columns.GridColumn colEuro;
    }
}