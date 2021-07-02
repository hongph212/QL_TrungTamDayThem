using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.BUS
{
    public class ChiTietPDK_BUS
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<CTPHIEUDK> LoadDSCTPDK()
        {
            return db.CTPHIEUDKs.ToList();
        }
        public bool ThemSuaCTPDK(CTPHIEUDK ctpdk)
        {
            if (db.CTPHIEUDKs.SingleOrDefault(x => x.MaLop == ctpdk.MaLop) == null)
            {
                try
                {
                    db.CTPHIEUDKs.InsertOnSubmit(ctpdk);
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                CTPHIEUDK update = db.CTPHIEUDKs.SingleOrDefault(x => x.MaLop == ctpdk.MaLop);
                update.MaLop = ctpdk.MaLop;
                db.SubmitChanges();
            }
            return true;
        }
        public bool XoaCTPDK(CTPHIEUDK ctpdk)
        {
            var deleteCTPDK =
                from CTPHIEUDK in db.CTPHIEUDKs
                where CTPHIEUDK.MaPhieuDK == ctpdk.MaPhieuDK && CTPHIEUDK.MaLop == ctpdk.MaLop
                select CTPHIEUDK;

            foreach (var detail in deleteCTPDK)
            {
                db.CTPHIEUDKs.DeleteOnSubmit(detail);
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
