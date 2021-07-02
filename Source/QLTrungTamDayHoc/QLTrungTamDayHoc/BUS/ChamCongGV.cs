using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.BUS
{
    public class ChamCongGV
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<DIEMDANH> LoadDSDD()
        {
            return db.DIEMDANHs.ToList();
        }

        public bool ThemSuaDD(DIEMDANH dd)
        {
            if (db.DIEMDANHs.SingleOrDefault(x => x.MaHV == dd.MaHV) == null)
            {
                try
                {
                    db.DIEMDANHs.InsertOnSubmit(dd);
                    db.SubmitChanges();
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                DIEMDANH update = db.DIEMDANHs.SingleOrDefault(x => x.MaHV == dd.MaHV);
                update.MaLop = dd.MaLop;
                update.NgayDiemDanh = dd.NgayDiemDanh;
                update.CoPhep = dd.CoPhep;
                db.SubmitChanges();
            }

            return true;
        }
        public bool XoaDD(DIEMDANH dd)
        {
            var deletedd =
                from DIEMDANH in db.DIEMDANHs
                where DIEMDANH.MaHV == dd.MaHV && DIEMDANH.MaLop == dd.MaLop && DIEMDANH.NgayDiemDanh == dd.NgayDiemDanh
                select DIEMDANH;

            foreach (var detail in deletedd)
            {
                db.DIEMDANHs.DeleteOnSubmit(detail);
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
