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
using DevExpress.XtraScheduler;

namespace QLTrungTamDayHoc
{
    public partial class frm_QLThoiKhoaBieu : DevExpress.XtraEditors.XtraUserControl
    {
        GiaoVien_BUS giaovien = new GiaoVien_BUS();
        ThoiKhoaBieu_BUS thoikhoabieu = new ThoiKhoaBieu_BUS();
        public frm_QLThoiKhoaBieu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void schedulerControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ThoiKhoaBieu_Load(object sender, EventArgs e)
        {
            gIAOVIENBindingSource.DataSource = giaovien.LoadDSGV();

        }
    }
}
