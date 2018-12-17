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
    public partial class UCTicketCountStatistics : UserControl
    {
        public UCTicketCountStatistics()
        {
            InitializeComponent();
        }

        private void btnStartStatistics_Click(object sender, EventArgs e)
        {
            DateTime BeginDate = this.DTPBeginDate.Value.Date;
            DateTime EndDate = this.DTPEndDate.Value.Date;

            string sql1 = string.Format("SELECT t.购票日期,a.类型,t.预订数量 FROM " +
                "(SELECT LEFT([购票时间], 10) AS 购票日期,礼堂ID,COUNT(*) AS 预订数量 " +
                "FROM 票务表 WHERE [购票时间] Between #{0}# AND #{1}# GROUP BY LEFT([购票时间], 10), 礼堂ID) t " +
                "LEFT JOIN [礼堂表] a ON t.礼堂ID = a.ID",
                BeginDate, EndDate);
            string sql2 = string.Format("SELECT s.*,t.预订数量 FROM " +
                "(SELECT [购买者ID],count(*) AS 预订数量 FROM 票务表 WHERE [购票时间] Between #{0}# AND #{1}# AND [购买者ID] <> 0 " +
                "GROUP BY [购买者ID]) t " +
                "LEFT JOIN [学生表] s ON t.购买者ID = s.学号",
                BeginDate, EndDate);
            string sql3 = string.Format("SELECT s.班级名称,SUM(t.预订数量) AS 总预订数量 FROM " +
                "(SELECT [购买者ID],count(*) AS 预订数量 FROM 票务表 WHERE [购票时间] Between #{0}# AND #{1}# AND [购买者ID] <> 0 " +
                "GROUP BY [购买者ID]) t " +
                "LEFT JOIN [学生表] s ON t.购买者ID = s.学号 " +
                "GROUP BY s.班级名称",
                BeginDate, EndDate);
            try
            {
                this.dataGridView1.DataSource = Access.obj.GetDataTable(sql1);
                this.dataGridView2.DataSource = Access.obj.GetDataTable(sql2);
                this.dataGridView3.DataSource = Access.obj.GetDataTable(sql3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
