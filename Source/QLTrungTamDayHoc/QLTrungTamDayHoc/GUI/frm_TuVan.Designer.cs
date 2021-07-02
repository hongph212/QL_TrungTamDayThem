namespace QLTrungTamDayHoc.GUI
{
    partial class frm_TuVan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TuVan));
            this.gv_CTPhieuDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLop = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid_PDK = new DevExpress.XtraGrid.GridControl();
            this.pHIEUDKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gv_PhieuDK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaPhieuDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongSoMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayDK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemHocVien = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHocVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenHocVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemNhanVien = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
            this.repositoryItemGridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.nav_PDK = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_DSPDK = new DevExpress.XtraNavBar.NavBarItem();
            this.nav_DiemDanh = new DevExpress.XtraNavBar.NavBarGroup();
            this.btn_DiemDanhHV = new DevExpress.XtraNavBar.NavBarItem();
            this.btn_ChamCongGV = new DevExpress.XtraNavBar.NavBarItem();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHANVIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOPs = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pn_TuVan = new System.Windows.Forms.Panel();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTPhieuDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhieuDK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHocVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.pn_TuVan.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_CTPhieuDK
            // 
            this.gv_CTPhieuDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLop});
            this.gv_CTPhieuDK.GridControl = this.grid_PDK;
            this.gv_CTPhieuDK.Name = "gv_CTPhieuDK";
            this.gv_CTPhieuDK.OptionsFind.AlwaysVisible = true;
            this.gv_CTPhieuDK.OptionsView.ShowGroupPanel = false;
            this.gv_CTPhieuDK.ViewCaption = "Chi Tiết PDK";
            // 
            // colMaLop
            // 
            this.colMaLop.Caption = "Tên Lớp";
            this.colMaLop.ColumnEdit = this.repositoryItemLop;
            this.colMaLop.FieldName = "MaLop";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 0;
            // 
            // repositoryItemLop
            // 
            this.repositoryItemLop.AutoHeight = false;
            this.repositoryItemLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLop.Name = "repositoryItemLop";
            this.repositoryItemLop.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaL,
            this.colTenLop});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaL
            // 
            this.colMaL.Caption = "Mã Lớp";
            this.colMaL.FieldName = "MaLop";
            this.colMaL.Name = "colMaL";
            this.colMaL.Visible = true;
            this.colMaL.VisibleIndex = 0;
            // 
            // colTenLop
            // 
            this.colTenLop.Caption = "Tên Lớp";
            this.colTenLop.FieldName = "TenLop";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.Visible = true;
            this.colTenLop.VisibleIndex = 1;
            // 
            // grid_PDK
            // 
            this.grid_PDK.Cursor = System.Windows.Forms.Cursors.Default;
            this.grid_PDK.DataSource = this.pHIEUDKBindingSource;
            this.grid_PDK.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gv_CTPhieuDK;
            gridLevelNode1.RelationName = "CTPHIEUDKs";
            this.grid_PDK.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid_PDK.Location = new System.Drawing.Point(0, 0);
            this.grid_PDK.MainView = this.gv_PhieuDK;
            this.grid_PDK.Name = "grid_PDK";
            this.grid_PDK.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHocVien,
            this.repositoryItemNhanVien,
            this.repositoryItemLop});
            this.grid_PDK.Size = new System.Drawing.Size(1041, 661);
            this.grid_PDK.TabIndex = 0;
            this.grid_PDK.UseEmbeddedNavigator = true;
            this.grid_PDK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_PhieuDK,
            this.gv_CTPhieuDK});
            this.grid_PDK.EditorKeyDown += new System.Windows.Forms.KeyEventHandler(this.gridControl1_EditorKeyDown);
            this.grid_PDK.Click += new System.EventHandler(this.grid_PDK_Click);
            // 
            // pHIEUDKBindingSource
            // 
            this.pHIEUDKBindingSource.DataSource = typeof(QLTrungTamDayHoc.PHIEUDK);
            // 
            // gv_PhieuDK
            // 
            this.gv_PhieuDK.ChildGridLevelName = "CTPHIEUDKs";
            this.gv_PhieuDK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaPhieuDK,
            this.colTongSoMon,
            this.colNgayDK,
            this.colMaHV,
            this.coMaNV});
            this.gv_PhieuDK.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gv_PhieuDK.GridControl = this.grid_PDK;
            this.gv_PhieuDK.Name = "gv_PhieuDK";
            this.gv_PhieuDK.OptionsFind.AlwaysVisible = true;
            this.gv_PhieuDK.OptionsSelection.MultiSelect = true;
            this.gv_PhieuDK.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gv_PhieuDK.OptionsView.ShowFooter = true;
            this.gv_PhieuDK.OptionsView.ShowGroupPanel = false;
            this.gv_PhieuDK.RowDeleting += new DevExpress.Data.RowDeletingEventHandler(this.gv_PhieuDK_RowDeleting);
            this.gv_PhieuDK.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gv_PhieuDK_RowDeleted);
            // 
            // colMaPhieuDK
            // 
            this.colMaPhieuDK.Caption = "Mã Phiếu ĐK";
            this.colMaPhieuDK.FieldName = "MaPhieuDK";
            this.colMaPhieuDK.Name = "colMaPhieuDK";
            this.colMaPhieuDK.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colMaPhieuDK.Visible = true;
            this.colMaPhieuDK.VisibleIndex = 0;
            // 
            // colTongSoMon
            // 
            this.colTongSoMon.Caption = "Tổng Số Môn";
            this.colTongSoMon.FieldName = "TongSoMon";
            this.colTongSoMon.Name = "colTongSoMon";
            this.colTongSoMon.Visible = true;
            this.colTongSoMon.VisibleIndex = 1;
            // 
            // colNgayDK
            // 
            this.colNgayDK.Caption = "Ngày ĐK";
            this.colNgayDK.FieldName = "NgayDK";
            this.colNgayDK.Name = "colNgayDK";
            this.colNgayDK.Visible = true;
            this.colNgayDK.VisibleIndex = 2;
            // 
            // colMaHV
            // 
            this.colMaHV.Caption = "Học Viên";
            this.colMaHV.ColumnEdit = this.repositoryItemHocVien;
            this.colMaHV.FieldName = "MaHV";
            this.colMaHV.Name = "colMaHV";
            this.colMaHV.Visible = true;
            this.colMaHV.VisibleIndex = 3;
            // 
            // repositoryItemHocVien
            // 
            this.repositoryItemHocVien.AutoHeight = false;
            this.repositoryItemHocVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemHocVien.Name = "repositoryItemHocVien";
            this.repositoryItemHocVien.View = this.repositoryItemGridLookUpEdit1View;
            // 
            // repositoryItemGridLookUpEdit1View
            // 
            this.repositoryItemGridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHocVien,
            this.colTenHocVien});
            this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
            this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaHocVien
            // 
            this.colMaHocVien.Caption = "Mã Học Viên";
            this.colMaHocVien.FieldName = "MaHV";
            this.colMaHocVien.Name = "colMaHocVien";
            this.colMaHocVien.Visible = true;
            this.colMaHocVien.VisibleIndex = 0;
            // 
            // colTenHocVien
            // 
            this.colTenHocVien.Caption = "Họ Tên Học Viên";
            this.colTenHocVien.FieldName = "TenHV";
            this.colTenHocVien.Name = "colTenHocVien";
            this.colTenHocVien.Visible = true;
            this.colTenHocVien.VisibleIndex = 1;
            // 
            // coMaNV
            // 
            this.coMaNV.Caption = "Nhân Viên";
            this.coMaNV.ColumnEdit = this.repositoryItemNhanVien;
            this.coMaNV.FieldName = "MaNV";
            this.coMaNV.Name = "coMaNV";
            this.coMaNV.Visible = true;
            this.coMaNV.VisibleIndex = 4;
            // 
            // repositoryItemNhanVien
            // 
            this.repositoryItemNhanVien.AutoHeight = false;
            this.repositoryItemNhanVien.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemNhanVien.Name = "repositoryItemNhanVien";
            this.repositoryItemNhanVien.View = this.repositoryItemGridLookUpEdit2View;
            // 
            // repositoryItemGridLookUpEdit2View
            // 
            this.repositoryItemGridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNhanVien,
            this.colTenNV});
            this.repositoryItemGridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemGridLookUpEdit2View.Name = "repositoryItemGridLookUpEdit2View";
            this.repositoryItemGridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemGridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNhanVien
            // 
            this.colMaNhanVien.Caption = "Mã Nhân Viên";
            this.colMaNhanVien.FieldName = "MaNV";
            this.colMaNhanVien.Name = "colMaNhanVien";
            this.colMaNhanVien.Visible = true;
            this.colMaNhanVien.VisibleIndex = 0;
            // 
            // colTenNV
            // 
            this.colTenNV.Caption = "Họ Tên Nhân Viên";
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 1;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane"});
            // 
            // dockPanel2
            // 
            this.dockPanel2.Appearance.BackColor = System.Drawing.Color.Azure;
            this.dockPanel2.Appearance.BackColor2 = System.Drawing.Color.Azure;
            this.dockPanel2.Appearance.BorderColor = System.Drawing.Color.Azure;
            this.dockPanel2.Appearance.Options.UseBackColor = true;
            this.dockPanel2.Appearance.Options.UseBorderColor = true;
            this.dockPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel2.ID = new System.Guid("8bdb1334-7e2d-422e-8723-58608d1918a0");
            this.dockPanel2.Location = new System.Drawing.Point(0, 0);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.OriginalSize = new System.Drawing.Size(261, 200);
            this.dockPanel2.Size = new System.Drawing.Size(261, 687);
            this.dockPanel2.Text = "Chức Năng";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.navBarControl1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(4, 24);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(253, 659);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.nav_PDK;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nav_PDK,
            this.nav_DiemDanh,
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btn_DSPDK,
            this.btn_DiemDanhHV,
            this.btn_ChamCongGV,
            this.navBarItem1});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.Azure;
            this.navBarControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 253;
            this.navBarControl1.Size = new System.Drawing.Size(253, 659);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // nav_PDK
            // 
            this.nav_PDK.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_PDK.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.nav_PDK.Appearance.Options.UseFont = true;
            this.nav_PDK.Appearance.Options.UseForeColor = true;
            this.nav_PDK.AppearanceBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.nav_PDK.Caption = "Phiếu Đăng Ký";
            this.nav_PDK.Expanded = true;
            this.nav_PDK.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.nav_PDK.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_DSPDK)});
            this.nav_PDK.Name = "nav_PDK";
            // 
            // btn_DSPDK
            // 
            this.btn_DSPDK.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DSPDK.Appearance.Options.UseFont = true;
            this.btn_DSPDK.Caption = "DS Phiếu Đăng Ký";
            this.btn_DSPDK.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DSPDK.LargeImage")));
            this.btn_DSPDK.Name = "btn_DSPDK";
            this.btn_DSPDK.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_DSPDK.SmallImage")));
            this.btn_DSPDK.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_DSPDK_LinkClicked);
            // 
            // nav_DiemDanh
            // 
            this.nav_DiemDanh.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nav_DiemDanh.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.nav_DiemDanh.Appearance.Options.UseFont = true;
            this.nav_DiemDanh.Appearance.Options.UseForeColor = true;
            this.nav_DiemDanh.Caption = "Danh Sách Điểm Danh";
            this.nav_DiemDanh.Expanded = true;
            this.nav_DiemDanh.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_DiemDanhHV),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btn_ChamCongGV)});
            this.nav_DiemDanh.Name = "nav_DiemDanh";
            // 
            // btn_DiemDanhHV
            // 
            this.btn_DiemDanhHV.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DiemDanhHV.Appearance.Options.UseFont = true;
            this.btn_DiemDanhHV.Caption = "Điểm Danh Học Viên";
            this.btn_DiemDanhHV.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DiemDanhHV.LargeImage")));
            this.btn_DiemDanhHV.Name = "btn_DiemDanhHV";
            this.btn_DiemDanhHV.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_DiemDanhHV.SmallImage")));
            // 
            // btn_ChamCongGV
            // 
            this.btn_ChamCongGV.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChamCongGV.Appearance.Options.UseFont = true;
            this.btn_ChamCongGV.Caption = "Điểm Danh Giáo Viên";
            this.btn_ChamCongGV.Name = "btn_ChamCongGV";
            this.btn_ChamCongGV.SmallImage = ((System.Drawing.Image)(resources.GetObject("btn_ChamCongGV.SmallImage")));
            this.btn_ChamCongGV.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btn_ChamCongGV_LinkClicked);
            // 
            // colMaNV
            // 
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            // 
            // colHOCVIEN
            // 
            this.colHOCVIEN.FieldName = "HOCVIEN";
            this.colHOCVIEN.Name = "colHOCVIEN";
            // 
            // colNHANVIEN
            // 
            this.colNHANVIEN.FieldName = "NHANVIEN";
            this.colNHANVIEN.Name = "colNHANVIEN";
            // 
            // colLOPs
            // 
            this.colLOPs.FieldName = "LOPs";
            this.colLOPs.Name = "colLOPs";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.Appearance.Options.UseForeColor = true;
            this.groupControl1.Controls.Add(this.pn_TuVan);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(261, 0);
            this.groupControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.DeepSkyBlue;
            this.groupControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1045, 687);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Phiếu Đăng Ký";
            // 
            // pn_TuVan
            // 
            this.pn_TuVan.BackColor = System.Drawing.Color.Azure;
            this.pn_TuVan.Controls.Add(this.grid_PDK);
            this.pn_TuVan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_TuVan.Location = new System.Drawing.Point(2, 24);
            this.pn_TuVan.Name = "pn_TuVan";
            this.pn_TuVan.Size = new System.Drawing.Size(1041, 661);
            this.pn_TuVan.TabIndex = 1;
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarGroup1.Appearance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.navBarGroup1.Appearance.Options.UseFont = true;
            this.navBarGroup1.Appearance.Options.UseForeColor = true;
            this.navBarGroup1.Caption = "Thống Kê";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBarItem1.Appearance.Options.UseFont = true;
            this.navBarItem1.Caption = "Thống Kê";
            this.navBarItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.LargeImage")));
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.SmallImage")));
            // 
            // frm_TuVan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dockPanel2);
            this.Name = "frm_TuVan";
            this.Size = new System.Drawing.Size(1306, 687);
            this.Load += new System.EventHandler(this.frm_TuVan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_CTPhieuDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_PDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHIEUDKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_PhieuDK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHocVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.pn_TuVan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup nav_PDK;
        private DevExpress.XtraNavBar.NavBarGroup nav_DiemDanh;
        private DevExpress.XtraNavBar.NavBarItem btn_DSPDK;
        private DevExpress.XtraNavBar.NavBarItem btn_DiemDanhHV;
        private DevExpress.XtraNavBar.NavBarItem btn_ChamCongGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNHANVIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colLOPs;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource pHIEUDKBindingSource;
        private DevExpress.XtraGrid.GridControl grid_PDK;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_PhieuDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaPhieuDK;
        private DevExpress.XtraGrid.Columns.GridColumn colTongSoMon;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHV;
        private DevExpress.XtraGrid.Columns.GridColumn coMaNV;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_CTPhieuDK;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemHocVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHocVien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenHocVien;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit2View;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemLop;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaL;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLop;
        private System.Windows.Forms.Panel pn_TuVan;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
    }
}
