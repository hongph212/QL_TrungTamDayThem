using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTrungTamDayHoc.BUS;

namespace QLTrungTamDayHoc.GUI
{
    public partial class frm_QLGiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        GiaoVien_BUS gv = new GiaoVien_BUS();

        public frm_QLGiaoVien()
        {
            InitializeComponent();
        }

        private void frm_DSGiaoVIen_Load(object sender, EventArgs e)
        {
            gIAOVIENBindingSource.DataSource = gv.LoadDSGV();
        }
    }
}
