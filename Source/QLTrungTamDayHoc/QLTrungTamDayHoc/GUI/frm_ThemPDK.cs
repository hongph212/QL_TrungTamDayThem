using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLTrungTamDayHoc
{
    public partial class frm_ThemPDK : DevExpress.XtraEditors.XtraForm 
    {
    //    KetNoiCSDL conn;

    //    public frm_ThemPDK()
    //    {
    //        InitializeComponent();
    //    }

    //    private DataTable LoadComboboxKhoi()
    //    {
    //        string sql = "select * from Khoi";

    //        SqlDataAdapter da = new SqlDataAdapter(sql, conn);

    //        da.Fill(ds, "ChucVu");

    //        return ds.Tables["ChucVu"];
    //    }

    //    private void btnThem_Click(object sender, EventArgs e)
    //    {
    //        //Duyệt radio, lấy text
    //        string rdo_Checked;

    //        if (rdo_Nam.Checked)
    //        {
    //            rdo_Checked = "Nam";
    //        }
    //        else
    //        {
    //            rdo_Checked = "Nữ";
    //        }
    //        //Kết nối thêm nhân viên
    //        if (!String.IsNullOrEmpty(txt_HoTen.Text) && !String.IsNullOrEmpty(txt_SDT.Text) && !String.IsNullOrEmpty(txt_DiaChi.Text) && !String.IsNullOrEmpty(txt_NgaySinh.Text))
    //        {
    //                if (dt.ThemNV(txt_HoTen.Text, txt_User.Text, txt_SDT.Text, txt_DiaChi.Text, txt_NgaySinh.Text, rdo_Checked, cbo_Khoi.SelectedValue.ToString(), txt_NgayVL.Text))
    //                {
    //                    MessageBox.Show("Thêm nhân viên thành công !");
    //                    ((DataTable)grid_DSNV.DataSource).Rows.Clear();
    //                    grid_DSNV.DataSource = dt.Load_DSNV();
    //                }
    //                else
    //                {
    //                    MessageBox.Show("Thêm nhân viên thất bại !");
    //                }
    //            }
    //            else
    //            {
    //                MessageBox.Show("Mã nhân viên hoặc sdt đã tồn tại !!");
    //            }
            
    //        else
    //            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !");

    //    }
    }
}