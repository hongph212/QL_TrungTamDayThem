using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.BUS
{

    public class PhieuDangKy_BUS
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<PHIEUDK> LoadDSPDK()
        {
            return db.PHIEUDKs.ToList();
        }
        public bool ThemSuaPDK(PHIEUDK pdk)
        {
            if (db.PHIEUDKs.SingleOrDefault(x => x.MaPhieuDK == pdk.MaPhieuDK) == null)
            {
                try
                {
                    db.PHIEUDKs.InsertOnSubmit(pdk);
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                PHIEUDK update = db.PHIEUDKs.SingleOrDefault(x => x.MaPhieuDK == pdk.MaPhieuDK);
                update.NgayDK = pdk.NgayDK;
                update.TongSoMon = pdk.TongSoMon;
                update.MaNV = pdk.MaNV;
                update.MaHV = pdk.MaHV;
                db.SubmitChanges();
            }
            return true;
        }

        public bool XoaPDK(PHIEUDK pdk)
        {
            var deletePDK =
                from PHIEUDK in db.PHIEUDKs
                where PHIEUDK.MaPhieuDK == pdk.MaPhieuDK
                select PHIEUDK;

            foreach (var detail in deletePDK)
            {
                db.PHIEUDKs.DeleteOnSubmit(detail);
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
