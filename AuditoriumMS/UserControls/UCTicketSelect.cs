using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuditoriumMS.UserControls
{
    public partial class UCTicketSelect : UserControl
    {
        public UCTicketSelect()
        {
            InitializeComponent();
            this.cmbType.SelectedIndex = 0;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DateTime BeginTime = this.DTPBeginDate.Value.Date;
            BeginTime = BeginTime.AddHours((double)this.NUDBeginHour.Value);
            BeginTime = BeginTime.AddMinutes((double)this.NUDBeginMinute.Value);
            DateTime EndTime = this.DTPEndDate.Value.Date;
            EndTime = EndTime.AddHours((double)this.NUDEndHour.Value);
            EndTime = EndTime.AddMinutes((double)this.NUDEndMinute.Value);

            string selectType;
            if (this.cmbType.SelectedIndex == 0)
                selectType = "";
            else
                selectType = string.Format("[类型] = '{0}' AND ", this.cmbType.SelectedItem as string);
            string sql = string.Format("SELECT * FROM 礼堂表 WHERE {0} [开始时间] Between #{1}# AND #{2}#",
                selectType, BeginTime.ToString("yyyy-MM-dd HH:mm:ss"), EndTime.ToString("yyyy-MM-dd HH:mm:ss"));
            try
            {
                this.dataGridView1.DataSource = Access.obj.GetDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
