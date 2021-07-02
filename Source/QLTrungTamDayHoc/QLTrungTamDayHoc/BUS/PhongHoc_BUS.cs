using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTrungTamDayHoc.BUS
{
    public class PhongHoc_BUS
    {
        QL_TrungTamDayHocDataContext db = new QL_TrungTamDayHocDataContext();

        public List<PHONGHOC> LoadDSPH()
        {
            return db.PHONGHOCs.ToList();
        }
    }
}
