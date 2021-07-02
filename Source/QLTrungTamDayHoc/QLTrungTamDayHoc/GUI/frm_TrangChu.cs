using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QLTrungTamDayHoc.GUI;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace QLTrungTamDayHoc
{
    public partial class frm_TrangChu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form frm;
        UserControl uc;
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        private void btn_DangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            pc_Main.Controls.Clear();

            frm = new frm_DangNhap();
            frm.Show();
        }

        private void btn_ThemHV_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_QLHocVien();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_ThemLop_ItemClick(object sender, ItemClickEventArgs e)
        {
            pc_Main.Controls.Clear();

            frm = new frm_ThemLop();
            frm.Show();
        }

        private void btn_ThemKhoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            pc_Main.Controls.Clear();

            frm = new frm_ThemKhoi();
            frm.Show();
        }

        private void btn_ThemMon_ItemClick(object sender, ItemClickEventArgs e)
        {
            pc_Main.Controls.Clear();

            frm = new frm_ThemMonHoc();
            frm.Show();
        }

        private void btn_ThemGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_QLGiaoVien();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnPhongHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_QLPhongHoc();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_XemTKB_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_QLThoiKhoaBieu();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnXemTKBGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_TKBGiaoVien();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThongTinSV_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_QLHocVien();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnThongTinGV_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_QLGiaoVien();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_PDK_ItemClick(object sender, ItemClickEventArgs e)
        {
            uc = new frm_TuVan();
            uc.Dock = DockStyle.Fill;
            pc_Main.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btn_ThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            //SqlConnection conn = new SqlConnection(@"Data Source=BESNHI\MSSQLSERVER1;Initial Catalog=QL_TT;Integrated Security=True");
            //conn.Open();
            //SqlCommand cmd = new SqlCommand("Select * from PhieuLuong where MaGV ='"+barButtonItem2.Caption+"'");
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //conn.Close();

            //rp_PhieuLuong rp = new rp_PhieuLuong();
            //rp.DataSource = dt;
            //rp.ShowPreviewDialog();
        }





    }
}