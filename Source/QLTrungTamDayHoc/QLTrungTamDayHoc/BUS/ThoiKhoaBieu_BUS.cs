using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.BUS
{
    public class ThoiKhoaBieu_BUS
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<THOIKHOABIEU> LoadDSTKB()
        {
            return db.THOIKHOABIEUs.ToList();
        }
        public bool ThemSuaTKB(THOIKHOABIEU tkb)
        {
            if (db.THOIKHOABIEUs.SingleOrDefault(x => x.MATKB == tkb.MATKB) == null)
            {
                try
                {
                    db.THOIKHOABIEUs.InsertOnSubmit(tkb);
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                THOIKHOABIEU update = db.THOIKHOABIEUs.SingleOrDefault(x => x.MATKB == tkb.MATKB);
                update.MaBuoi = tkb.MaBuoi;
                update.MaCH = tkb.MaCH;
                update.MaPH = tkb.MaPH;
                db.SubmitChanges();
            }
            return true;
        }

        public bool XoaTKB(THOIKHOABIEU tkb)
        {
            try
            {
                db.THOIKHOABIEUs.DeleteOnSubmit(tkb);
                db.SubmitChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
