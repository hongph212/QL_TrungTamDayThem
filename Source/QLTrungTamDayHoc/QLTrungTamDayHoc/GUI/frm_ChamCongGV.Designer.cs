namespace QLTrungTamDayHoc.GUI
{
    partial class frm_ChamCongGV
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dIEMDANHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_ChamCongGV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colNgayDiemDanh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCoPhep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMDANHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChamCongGV)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.dIEMDANHBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gv_ChamCongGV;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1041, 661);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_ChamCongGV});
            // 
            // dIEMDANHBindingSource
            // 
            this.dIEMDANHBindingSource.DataSource = typeof(QLTrungTamDayHoc.DIEMDANH);
            // 
            // gv_ChamCongGV
            // 
            this.gv_ChamCongGV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colNgayDiemDanh,
            this.colCoPhep,
            this.colMaHV,
            this.colMaLop,
            this.colHOCVIEN,
            this.colLOP});
            this.gv_ChamCongGV.GridControl = this.gridControl1;
            this.gv_ChamCongGV.Name = "gv_ChamCongGV";
            // 
            // colNgayDiemDanh
            // 
            this.colNgayDiemDanh.FieldName = "NgayDiemDanh";
            this.colNgayDiemDanh.Name = "colNgayDiemDanh";
            this.colNgayDiemDanh.Visible = true;
            this.colNgayDiemDanh.VisibleIndex = 0;
            // 
            // colCoPhep
            // 
            this.colCoPhep.FieldName = "CoPhep";
            this.colCoPhep.Name = "colCoPhep";
            this.colCoPhep.Visible = true;
            this.colCoPhep.VisibleIndex = 1;
            // 
            // colMaHV
            // 
            this.colMaHV.FieldName = "MaHV";
            this.colMaHV.Name = "colMaHV";
            this.colMaHV.Visible = true;
            this.colMaHV.VisibleIndex = 2;
            // 
            // colMaLop
            // 
            this.colMaLop.FieldName = "MaLop";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 3;
            // 
            // colHOCVIEN
            // 
            this.colHOCVIEN.FieldName = "HOCVIEN";
            this.colHOCVIEN.Name = "colHOCVIEN";
            this.colHOCVIEN.Visible = true;
            this.colHOCVIEN.VisibleIndex = 4;
            // 
            // colLOP
            // 
            this.colLOP.FieldName = "LOP";
            this.colLOP.Name = "colLOP";
            this.colLOP.Visible = true;
            this.colLOP.VisibleIndex = 5;
            // 
            // frm_ChamCongGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_ChamCongGV";
            this.Size = new System.Drawing.Size(1041, 661);
            this.Load += new System.EventHandler(this.frm_DiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIEMDANHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_ChamCongGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_ChamCongGV;
        private System.Windows.Forms.BindingSource dIEMDANHBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDiemDanh;
        private DevExpress.XtraGrid.Columns.GridColumn colCoPhep;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colLOP;
    }
}
