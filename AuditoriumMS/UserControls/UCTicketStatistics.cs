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
    public partial class UCTicketStatistics : UserControl
    {
        public UCTicketStatistics()
        {
            InitializeComponent();
        }

        private void btnStartStatistics_Click(object sender, EventArgs e)
        {
            DateTime BeginDate = this.DTPBeginDate.Value.Date;
            DateTime EndDate = this.DTPEndDate.Value.Date;

            string sql = string.Format("SELECT LEFT([开始时间], 10) AS 日期,COUNT(*) AS 总场次," +
                "SUM(IIF([类型] = '讲座', 1, 0)) AS 讲座场次, 总场次-讲座场次 AS 电影场次 " +
                "FROM [礼堂表] " +
                "WHERE [开始时间] Between #{0}# AND #{1}# GROUP BY LEFT([开始时间], 10)",
                BeginDate, EndDate);
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
