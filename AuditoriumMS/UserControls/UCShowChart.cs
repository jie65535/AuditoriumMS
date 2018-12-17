using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace AuditoriumMS.UserControls
{
    public partial class UCShowChart : UserControl
    {
        public UCShowChart()
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
            try
            {
                DataTable dt = Access.obj.GetDataTable(sql1);
                foreach (DataRow row in dt.Rows)
                {
                    DataPoint point = new DataPoint();
                    point.SetValueXY(row["购票日期"], row["预订数量"]);
                    point.ToolTip = row["类型"].ToString();
                    this.chart1.Series[0].Points.Add(point);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
