namespace QLTrungTamDayHoc.GUI
{
    partial class frm_QLPhongHoc
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.pHONGHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gv_PhongHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenPH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucChua = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhongHoc)).BeginInit();
            this.SuspendLayout();
            // 
            // pHONGHOCBindingSource
            // 
            this.pHONGHOCBindingSource.DataSource = typeof(QLTrungTamDayHoc.PHONGHOC);
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.pHONGHOCBindingSource;
            gridLevelNode3.RelationName = "CHAMCONGs";
            gridLevelNode2.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3});
            gridLevelNode2.RelationName = "PHANCONGs";
            gridLevelNode1.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            gridLevelNode1.RelationName = "THOIKHOABIEUs";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(3, 3);
            this.gridControl1.MainView = this.gv_PhongHoc;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1300, 681);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PhongHoc});
            // 
            // gv_PhongHoc
            // 
            this.gv_PhongHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPH,
            this.colTenPH,
            this.colSucChua});
            this.gv_PhongHoc.GridControl = this.gridControl1;
            this.gv_PhongHoc.Name = "gv_PhongHoc";
            // 
            // colMaPH
            // 
            this.colMaPH.FieldName = "MaPH";
            this.colMaPH.Name = "colMaPH";
            this.colMaPH.Visible = true;
            this.colMaPH.VisibleIndex = 0;
            // 
            // colTenPH
            // 
            this.colTenPH.FieldName = "TenPH";
            this.colTenPH.Name = "colTenPH";
            this.colTenPH.Visible = true;
            this.colTenPH.VisibleIndex = 1;
            // 
            // colSucChua
            // 
            this.colSucChua.FieldName = "SucChua";
            this.colSucChua.Name = "colSucChua";
            this.colSucChua.Visible = true;
            this.colSucChua.VisibleIndex = 2;
            // 
            // frm_QLPhongHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "frm_QLPhongHoc";
            this.Size = new System.Drawing.Size(1306, 687);
            this.Load += new System.EventHandler(this.frm_QLPhongHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHONGHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhongHoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource pHONGHOCBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PhongHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenPH;
        private DevExpress.XtraGrid.Columns.GridColumn colSucChua;
    }
}
