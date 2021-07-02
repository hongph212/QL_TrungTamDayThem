using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.BUS
{
    public class BienLai_BUS
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<BIENLAI> LoadDSBL()
        {
            return db.BIENLAIs.ToList();
        }

        public bool ThemSuaBL(BIENLAI bl)
        {
            if (db.BIENLAIs.SingleOrDefault(x => x.MaBienLai == bl.MaBienLai) == null)
            {
                try
                {
                    db.BIENLAIs.InsertOnSubmit(bl);
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                BIENLAI update = db.BIENLAIs.SingleOrDefault(x => x.MaBienLai == bl.MaBienLai);
                update.NgayDong = bl.NgayDong;
                update.MaHV = bl.MaHV;
                update.MaNV = bl.MaNV;
                update.NgayDong = bl.NgayDong;
                update.SoTien = bl.SoTien;
                db.SubmitChanges();
            }

            return true;
        }
        public bool XoaBL(BIENLAI bl)
        {
            var deletebl =
                from BIENLAI in db.BIENLAIs
                where BIENLAI.MaBienLai == bl.MaBienLai
                select BIENLAI;

            foreach (var detail in deletebl)
            {
                db.BIENLAIs.DeleteOnSubmit(detail);
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

