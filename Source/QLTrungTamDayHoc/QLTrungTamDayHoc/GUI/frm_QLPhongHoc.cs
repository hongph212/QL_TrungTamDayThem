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
    public partial class frm_QLPhongHoc : UserControl
    {
        PhongHoc_BUS ph = new PhongHoc_BUS();

        public frm_QLPhongHoc()
        {
            InitializeComponent();
        }

        private void frm_QLPhongHoc_Load(object sender, EventArgs e)
        {
            pHONGHOCBindingSource.DataSource = ph.LoadDSPH();
        }
    }
}
