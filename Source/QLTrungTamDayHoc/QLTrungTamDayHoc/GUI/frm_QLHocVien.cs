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

namespace QLTrungTamDayHoc
{
    public partial class frm_QLHocVien : UserControl
    {
        HocVien_BUS hocvien = new HocVien_BUS();
        HOCVIEN hv = new HOCVIEN();

        NhanVien_BUS nhanvien = new NhanVien_BUS();

        PhieuDangKy_BUS phieudangky = new PhieuDangKy_BUS();
        PHIEUDK pdk = new PHIEUDK();

        ChiTietPDK_BUS chitietpdk = new ChiTietPDK_BUS();
        CTPHIEUDK ctpdk = new CTPHIEUDK();

        Lop_BUS lop = new Lop_BUS();

        BienLai_BUS bienlai = new BienLai_BUS();
        BIENLAI bl = new BIENLAI();

        ChamCongGV diemdanh = new ChamCongGV();
        DIEMDANH dd = new DIEMDANH();

        public frm_QLHocVien()
        {
            InitializeComponent();
        }

        private void frm_DSHocVien_Load(object sender, EventArgs e)
        {
            hOCVIENBindingSource.DataSource = hocvien.LoadDSHV();

            //Load combobox danh sách nhân viên
            repositoryItemNhanVien.DataSource = nhanvien.LoadDSNV();

            repositoryItemNhanVien.ValueMember = "MaNV";
            repositoryItemNhanVien.DisplayMember = "TenNV";

            repositoryItemNhanVien.NullText = "Chọn nhân viên";


            //Load combobox danh sách lớp
            repositoryItemLop.DataSource = lop.LoadDSL();

            repositoryItemLop.ValueMember = "MaLop";
            repositoryItemLop.DisplayMember = "TenLop";

            repositoryItemLop.NullText = "Chọn lớp";


            //Load combobox Giới tính
            repositoryCboGioiTinh.Items.Add("Nam");
            repositoryCboGioiTinh.Items.Add("Nữ");
        }

        private void grid_DSHV_EditorKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HOCVIEN hv1 = new HOCVIEN();
                grid_DSHV.MainView.UpdateCurrentRow();
                for (int i = 0; i < gv_HocVien.RowCount; i++)
                {
                    if (gv_HocVien.IsRowSelected(i) == true)
                    {
                        var a = grid_DSHV.MainView.GetRow(i);
                        hv1 = ((HOCVIEN)a);
                        hocvien.ThemSuaHV(hv1);
                        hOCVIENBindingSource.DataSource = hocvien.LoadDSHV();
                    }
                }
            }
        }

        private void grid_DSHV_Click(object sender, EventArgs e)
        {
            //    for (int i = 0; i < gv_HocVien.RowCount; i++)
            //    {
            //        if (gv_HocVien.IsRowSelected(i) == true)
            //        {
            //            var a = grid_DSHV.MainView.GetRow(i);
            //            hv = ((HOCVIEN)a);
            //        }
            //    }
        }

        private void gridView_HocVien_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá học viên ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                hocvien.XoaHV(hv);
            }
        }

        private void gridView_HocVien_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            gv_HocVien.RefreshData();
        }

        private void gv_HocVien_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            for (int i = 0; i < gv_HocVien.RowCount; i++)
            {
                if (gv_HocVien.IsRowSelected(i) == true)
                {
                    var a = grid_DSHV.MainView.GetRow(i);
                    hv = ((HOCVIEN)a);
                }
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------//
        //Gridview lv2 Phiếu Đăng Ký
        private void gv_PDK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PHIEUDK pdk1 = new PHIEUDK();
                gv_PDK.UpdateCurrentRow();
            }
        }
        private void gv_PDK_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            gv_PDK.RefreshData();
        }

        private void gv_PDK_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá phiếu đăng ký ? ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GridView gridview = sender as GridView;
                Object b = gridview.GetFocusedRow();

                pdk = ((PHIEUDK)b);

                if (phieudangky.XoaPDK(pdk) == true)

                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Chưa xoá được");
            }
        }
        
        //------------------------------------------------------------------------------------------------------------------------------------------------//
        //Gridview lv2 Biên Lai

        private void gv_BienLai_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            gv_BienLai.RefreshData();
        }

        private void gv_BienLai_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá biên lai này ? ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GridView gridview = sender as GridView;
                Object b = gridview.GetFocusedRow();

                bl = ((BIENLAI)b);

                if (bienlai.XoaBL(bl) == true)

                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Chưa xoá được");
            }
        }

        private void gv_BienLai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BIENLAI bl1 = new BIENLAI();
                gv_BienLai.UpdateCurrentRow();
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------//
        //Gridview lv2 Biên Lai
        private void gv_DiemDanh_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            gv_DiemDanh.RefreshData();
        }

        private void gv_DiemDanh_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá điểm danh này ? ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GridView gridview = sender as GridView;
                Object b = gridview.GetFocusedRow();

                dd = ((DIEMDANH)b);

                if (diemdanh.XoaDD(dd) == true)

                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Chưa xoá được");
            }
        }

        private void gv_DiemDanh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DIEMDANH bl1 = new DIEMDANH();
                gv_DiemDanh.UpdateCurrentRow();
            }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------//
        //Gridview lv3 CT Phiếu Đăng Ký
        private void gv_CTPDK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CTPHIEUDK ctpdk1 = new CTPHIEUDK();
                gv_CTPDK.UpdateCurrentRow();
            }
        }
        private void gv_CTPDK_RowDeleted(object sender, DevExpress.Data.RowDeletedEventArgs e)
        {
            gv_CTPDK.RefreshData();
        }

        private void gv_CTPDK_RowDeleting(object sender, DevExpress.Data.RowDeletingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá môn này ? ", "Xoá", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                GridView gridview = sender as GridView;
                Object b = gridview.GetFocusedRow();

                ctpdk = ((CTPHIEUDK)b);

                if (chitietpdk.XoaCTPDK(ctpdk) == true)

                    MessageBox.Show("Xoá thành công");
                else
                    MessageBox.Show("Chưa xoá được");
            }
        }
    }
}
