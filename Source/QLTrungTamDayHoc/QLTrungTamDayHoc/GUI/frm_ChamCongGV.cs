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
    public partial class frm_ChamCongGV : UserControl
    {
        ChamCongGV dd = new ChamCongGV();
        public frm_ChamCongGV()
        {
            InitializeComponent();
        }

        private void frm_DiemDanh_Load(object sender, EventArgs e)
        {
            dIEMDANHBindingSource.DataSource = dd.LoadDSDD();
        }
    }
}
