using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QLTrungTamDayHoc.BUS
{
    public class HocVien_BUS
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<HOCVIEN> LoadDSHV()
        {
            return db.HOCVIENs.ToList();
        }

        public bool ThemSuaHV(HOCVIEN hv)
        {
            if (db.HOCVIENs.SingleOrDefault(x => x.MaHV == hv.MaHV) == null)
            {
                try
                {
                    db.HOCVIENs.InsertOnSubmit(hv);
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                HOCVIEN update = db.HOCVIENs.SingleOrDefault(x => x.MaHV == hv.MaHV);
                update.TenHV = hv.TenHV;
                update.SDT = hv.SDT;
                update.NgaySinh = hv.NgaySinh;
                update.GioiTinh = hv.GioiTinh;
                update.DiaChi = hv.DiaChi;
                update.DiemDauVao = hv.DiemDauVao;
                db.SubmitChanges();
            }

            return true;
        }
        public bool XoaHV(HOCVIEN hv)
        {
            var deletehv =
                from HOCVIEN in db.HOCVIENs
                where HOCVIEN.MaHV == hv.MaHV
                select HOCVIEN;

            foreach (var detail in deletehv)
            {
                db.HOCVIENs.DeleteOnSubmit(detail);
                break;
            }

            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return true;
        }
    }
}
