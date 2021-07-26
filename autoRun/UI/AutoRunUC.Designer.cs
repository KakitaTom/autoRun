
namespace autoRun.UI
{
    partial class AutoRunUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoRunUC));
            this.gcUrlRun = new DevExpress.XtraGrid.GridControl();
            this.gvUrlRun = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NameCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.URL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TimeDeleyCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.fakeStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRunDetail = new DevExpress.XtraGrid.GridControl();
            this.gvRunDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DateCreateCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsActiveCol2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UrlRunIdCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnStatusChange = new DevExpress.XtraEditors.SimpleButton();
            this.gbAuto = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gcUrlRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrlRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRunDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRunDetail)).BeginInit();
            this.gbAuto.SuspendLayout();
            this.SuspendLayout();
            // 
            // gcUrlRun
            // 
            this.gcUrlRun.Location = new System.Drawing.Point(36, 82);
            this.gcUrlRun.MainView = this.gvUrlRun;
            this.gcUrlRun.Name = "gcUrlRun";
            this.gcUrlRun.Size = new System.Drawing.Size(1277, 243);
            this.gcUrlRun.TabIndex = 0;
            this.gcUrlRun.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvUrlRun});
            // 
            // gvUrlRun
            // 
            this.gvUrlRun.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NameCol,
            this.URL,
            this.TimeDeleyCol,
            this.IsActive,
            this.Id,
            this.fakeStatus});
            this.gvUrlRun.GridControl = this.gcUrlRun;
            this.gvUrlRun.Name = "gvUrlRun";
            this.gvUrlRun.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvUrlRun_FocusedRowChanged);
            // 
            // NameCol
            // 
            this.NameCol.Caption = "Name";
            this.NameCol.FieldName = "Name";
            this.NameCol.Name = "NameCol";
            this.NameCol.OptionsColumn.AllowEdit = false;
            this.NameCol.Visible = true;
            this.NameCol.VisibleIndex = 0;
            this.NameCol.Width = 137;
            // 
            // URL
            // 
            this.URL.Caption = "URL";
            this.URL.FieldName = "Url";
            this.URL.Name = "URL";
            this.URL.OptionsColumn.AllowEdit = false;
            this.URL.Visible = true;
            this.URL.VisibleIndex = 1;
            this.URL.Width = 248;
            // 
            // TimeDeleyCol
            // 
            this.TimeDeleyCol.Caption = "Thời gian run 1 lần (Giây)";
            this.TimeDeleyCol.FieldName = "TimeDeley";
            this.TimeDeleyCol.Name = "TimeDeleyCol";
            this.TimeDeleyCol.OptionsColumn.AllowEdit = false;
            this.TimeDeleyCol.Visible = true;
            this.TimeDeleyCol.VisibleIndex = 2;
            this.TimeDeleyCol.Width = 141;
            // 
            // IsActive
            // 
            this.IsActive.Caption = "Trạng thái real";
            this.IsActive.FieldName = "IsActive";
            this.IsActive.Name = "IsActive";
            this.IsActive.OptionsColumn.AllowEdit = false;
            this.IsActive.Width = 46;
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.OptionsColumn.AllowEdit = false;
            this.Id.Width = 113;
            // 
            // fakeStatus
            // 
            this.fakeStatus.Caption = "Trạng thái";
            this.fakeStatus.FieldName = "FakeStatus";
            this.fakeStatus.Name = "fakeStatus";
            this.fakeStatus.UnboundExpression = "Iif([IsActive], \'Hoạt động\', \'Không hoạt động\')";
            this.fakeStatus.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            this.fakeStatus.Visible = true;
            this.fakeStatus.VisibleIndex = 3;
            // 
            // gcRunDetail
            // 
            this.gcRunDetail.Location = new System.Drawing.Point(36, 331);
            this.gcRunDetail.MainView = this.gvRunDetail;
            this.gcRunDetail.Name = "gcRunDetail";
            this.gcRunDetail.Size = new System.Drawing.Size(1277, 219);
            this.gcRunDetail.TabIndex = 1;
            this.gcRunDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRunDetail});
            // 
            // gvRunDetail
            // 
            this.gvRunDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DateCreateCol,
            this.IsActiveCol2,
            this.IdCol,
            this.UrlRunIdCol});
            this.gvRunDetail.GridControl = this.gcRunDetail;
            this.gvRunDetail.Name = "gvRunDetail";
            // 
            // DateCreateCol
            // 
            this.DateCreateCol.Caption = "Thời gian chạy";
            this.DateCreateCol.FieldName = "DateCreate";
            this.DateCreateCol.Name = "DateCreateCol";
            this.DateCreateCol.OptionsColumn.AllowEdit = false;
            this.DateCreateCol.Visible = true;
            this.DateCreateCol.VisibleIndex = 0;
            // 
            // IsActiveCol2
            // 
            this.IsActiveCol2.Caption = "Trạng thái";
            this.IsActiveCol2.FieldName = "IsActive";
            this.IsActiveCol2.Name = "IsActiveCol2";
            this.IsActiveCol2.OptionsColumn.AllowEdit = false;
            this.IsActiveCol2.Visible = true;
            this.IsActiveCol2.VisibleIndex = 1;
            // 
            // IdCol
            // 
            this.IdCol.Caption = "Id";
            this.IdCol.FieldName = "Id";
            this.IdCol.Name = "IdCol";
            this.IdCol.OptionsColumn.AllowEdit = false;
            // 
            // UrlRunIdCol
            // 
            this.UrlRunIdCol.Caption = "UrlRunId";
            this.UrlRunIdCol.FieldName = "UrlRunId";
            this.UrlRunIdCol.Name = "UrlRunIdCol";
            this.UrlRunIdCol.OptionsColumn.AllowEdit = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Appearance.Options.UseFont = true;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Location = new System.Drawing.Point(36, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Appearance.Options.UseFont = true;
            this.btnEdit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEdit.ImageOptions.SvgImage")));
            this.btnEdit.Location = new System.Drawing.Point(142, 36);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 40);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Appearance.Options.UseFont = true;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Location = new System.Drawing.Point(248, 36);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 40);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnStatusChange
            // 
            this.btnStatusChange.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusChange.Appearance.Options.UseFont = true;
            this.btnStatusChange.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStatusChange.ImageOptions.SvgImage")));
            this.btnStatusChange.Location = new System.Drawing.Point(354, 36);
            this.btnStatusChange.Name = "btnStatusChange";
            this.btnStatusChange.Size = new System.Drawing.Size(194, 40);
            this.btnStatusChange.TabIndex = 5;
            this.btnStatusChange.Text = "Thay đổi trạng thái";
            this.btnStatusChange.Click += new System.EventHandler(this.btnStatusChange_Click);
            // 
            // gbAuto
            // 
            this.gbAuto.Controls.Add(this.btnAdd);
            this.gbAuto.Controls.Add(this.gcUrlRun);
            this.gbAuto.Controls.Add(this.gcRunDetail);
            this.gbAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAuto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAuto.ForeColor = System.Drawing.Color.Red;
            this.gbAuto.Location = new System.Drawing.Point(0, 0);
            this.gbAuto.Name = "gbAuto";
            this.gbAuto.Size = new System.Drawing.Size(1342, 556);
            this.gbAuto.TabIndex = 6;
            this.gbAuto.TabStop = false;
            this.gbAuto.Text = "Auto Run";
            // 
            // AutoRunUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStatusChange);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gbAuto);
            this.Name = "AutoRunUC";
            this.Size = new System.Drawing.Size(1342, 556);
            ((System.ComponentModel.ISupportInitialize)(this.gcUrlRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvUrlRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRunDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRunDetail)).EndInit();
            this.gbAuto.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcUrlRun;
        private DevExpress.XtraGrid.Views.Grid.GridView gvUrlRun;
        private DevExpress.XtraGrid.GridControl gcRunDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gvRunDetail;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.SimpleButton btnStatusChange;
        private DevExpress.XtraGrid.Columns.GridColumn NameCol;
        private DevExpress.XtraGrid.Columns.GridColumn URL;
        private DevExpress.XtraGrid.Columns.GridColumn TimeDeleyCol;
        private DevExpress.XtraGrid.Columns.GridColumn IsActive;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private DevExpress.XtraGrid.Columns.GridColumn DateCreateCol;
        private DevExpress.XtraGrid.Columns.GridColumn IsActiveCol2;
        private DevExpress.XtraGrid.Columns.GridColumn IdCol;
        private DevExpress.XtraGrid.Columns.GridColumn UrlRunIdCol;
        private System.Windows.Forms.GroupBox gbAuto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DevExpress.XtraGrid.Columns.GridColumn fakeStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}
