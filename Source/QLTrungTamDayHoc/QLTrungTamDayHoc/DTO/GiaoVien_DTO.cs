using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.DTO
{
    public class GiaoVien_DTO
    {
        int maGV;

        public int MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        string gioiTinh;

        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        string hoTen;

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }
        DateTime ngaySinh;

        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        string sdt;

        public string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
        float heSL;

        public float HeSL
        {
            get { return heSL; }
            set { heSL = value; }
        }
        float luongCB;

        public float LuongCB
        {
            get { return luongCB; }
            set { luongCB = value; }
        }
        int maMH;

        public int MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }

        //khởi tạo rỗng
        public GiaoVien_DTO()
        {
            MaGV = 0;
            HoTen = "";
            GioiTinh = "";
            NgaySinh = new DateTime();
            DiaChi = "";
            Sdt = "";
            HeSL = 0;
            LuongCB = 0;
            MaMH = 0;
        }

        //khởi tạo có tham chiếu
        public GiaoVien_DTO(int MaGV, string HoTen, string GioiTinh, DateTime NgaySinh, string DiaChi, string Sdt, float HeSL, float LuongCB, int MaMH) 
        {
            this.MaGV = MaGV;
            this.HoTen = HoTen;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.Sdt = Sdt;
            this.HeSL = HeSL;
            this.LuongCB = LuongCB;
            this.MaMH = MaMH;
        }
    }
}
