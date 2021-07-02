using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler;

namespace QLTrungTamDayHoc.GUI
{
    public partial class frm_TKBGiaoVien : DevExpress.XtraEditors.XtraUserControl
    {
        public frm_TKBGiaoVien()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void frm_TKBGiaoVien_Load(object sender, EventArgs e)

        {
            this.resourcesTableAdapter.Fill(this.schedulerTestDataSet.Resources);
            this.appointmentsTableAdapter.Fill(this.schedulerTestDataSet.Appointments);
        }

        private void newAppointmentItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Object a = schedulerCo
            //ntrol1.Storage.AppointmentsChanged;
        }

        private void schedulerStorage1_AppointmentsChanged(object sender, DevExpress.XtraScheduler.PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
        }

        private void schedulerStorage1_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            AppointmentBaseCollection apts = e.Objects as AppointmentBaseCollection;
            foreach (Appointment apt in apts)
            {
                DataRowView dataRow = apt.GetSourceObject(this.schedulerStorage1) as DataRowView;
                //String status = dataRow.Row["Status"].ToString();
                //String enddate = dataRow.Row["EndDate"].ToString();
                //string[] a = enddate.Split(' ');
                
            }

            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
            //string a = schedulerTestDataSet.Appointments.;
        }


    }
}
