using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTrungTamDayHoc.BUS;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Layout.Modes;

namespace QLTrungTamDayHoc.GUI
{
    public partial class frm_TuVan : DevExpress.XtraEditors.XtraUserControl
    {
        UserControl uc;
        //Form frm;
        HocVien_BUS hv = new HocVien_BUS();
        NhanVien_BUS nv = new NhanVien_BUS();
        PhieuDangKy_BUS pdk = new PhieuDangKy_BUS();
        Lop_BUS l = new Lop_BUS();
        PHIEUDK p = new PHIEUDK();

        public frm_TuVan()
        {
            InitializeComponent();
        }

        private void nav_ThemHV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //frm = new frm_ThemPDK();
            //frm.Show();
        }

        private void frm_TuVan_Load(object sender, EventArgs e)
        {
            //Load danh sách phiếu đăng ký
            pHIEUDKBindingSource.DataSource = pdk.LoadDSPDK();

            //Load combobox danh sách học viên
            repositoryItemHocVien.DataSource = hv.LoadDSHV();

            repositoryItemHocVien.ValueMember = "MaHV";
            repositoryItemHocVien.DisplayMember = "TenHV";

            repositoryItemHocVien.NullText = "Chọn học viên";

            //colMaHocVien.ColumnEdit = repositoryItemHocVien;

            //Load combobox danh sách nhân viên
            repositoryItemNhanVien.DataSource = nv.LoadDSNV();

            repositoryItemNhanVien.ValueMember = "MaNV";
            repositoryItemNhanVien.DisplayMember = "TenNV";

            repositoryItemNhanVien.NullText = "Chọn nhân viên";

            //colMaNhanVien.ColumnEdit = repositoryItemNhanVien;

            //Load combobox danh sách lớp
            repositoryItemLop.DataSource = l.LoadDSL();

            repositoryItemLop.ValueMember = "MaLop";
            repositoryItemLop.DisplayMember = "TenLop";

            repositoryItemLop.NullText = "Chọn lớp";

            //colMaL.ColumnEdit = repositoryItemLop;
        }

        private void gridControl1_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PHIEUDK pdk1 = new PHIEUDK();
                grid_PDK.MainView.UpdateCurrentRow();
                for (int i = 0; i < gv_PhieuDK.RowCount; i++)
                {
                    if (gv_PhieuDK.IsRowSelected(i) == true)
                    {
                        var a = grid_PDK.MainView.GetRow(i);
                        pdk1 = ((PHIEUDK)a);
                        
                        pdk.ThemSuaPDK(pdk1);
                        pHIEUDKBindingSource.DataSource = pdk.LoadDSPDK();
                    }
                }
            }
        }

        private void grid_PDK_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_PhieuDK.RowCount; i++)
            {
                if (gv_PhieuDK.IsRowSelected(i) == true)
                {
                    var a = grid_PDK.MainView.GetRow(i);
                    p = ((PHIEUDK)a);
                }
            }
        }

        private void gv_PhieuDK_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            pHIEUDKBindingSource.DataSource = pdk.LoadDSPDK();
        }

        private void gv_PhieuDK_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá phiếu đăng ký ? " + p.MaPhieuDK, "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                pdk.XoaPDK(p);
            }
        }

        private void btn_ChamCongGV_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            uc = new frm_ChamCongGV();
            uc.Dock = DockStyle.Fill;
            pn_TuVan.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_DSPDK_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //uc = new frm();
            //uc.Dock = DockStyle.Fill;
            //pn_TuVan.Controls.Add(uc);
            //uc.BringToFront();
        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
            uc = new frm_ThongKe();
            uc.Dock = DockStyle.Fill;
            pn_TuVan.Controls.Add(uc);
            uc.BringToFront();
        }

      
    }
}
