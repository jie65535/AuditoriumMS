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
    public partial class UCSummaryReport : UserControl
    {
        public UCSummaryReport()
        {
            InitializeComponent();
            this.cmbMonth.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtClassName.Text))
            {
                MessageBox.Show("请输入班级名称！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Access.IsHasSQLInject(this.txtClassName.Text))
            {
                MessageBox.Show("请输入规范字符！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int year = DateTime.Now.Year;
            int month = cmbMonth.SelectedIndex + 1;
            // 如果统计的月份大于当前月，表示统计去年的
            if (month > DateTime.Now.Month)
                year--;

            // 月初
            DateTime BeginDate = new DateTime(year, month, 1);
            // 月末
            DateTime EndDate = new DateTime(year, month, DateTime.DaysInMonth(year, month));

            
            string sql1 = string.Format("SELECT '{0}' AS 班级名称, '{1}' AS 起始日期, '{2}' AS 终止日期, COUNT(*) AS 预订票数 FROM [票务表] " +
                "WHERE [购买者ID] IN(SELECT [学号] FROM [学生表] WHERE [班级名称] = '{0}') " +
                "AND [购票时间] BETWEEN #{1}# AND #{2}#",
                this.txtClassName.Text, BeginDate.ToShortDateString(), EndDate.ToShortDateString());
            string sql2 = string.Format("SELECT st.学号,st.姓名,LEFT(a.开始时间,10) AS 日期,WeekDay(a.开始时间) AS 星期,Format(a.开始时间,'HH:mm') AS 时间,a.类型 FROM " +
                "(SELECT * FROM " +
                "(SELECT [学号],[姓名] FROM [学生表] WHERE [班级名称] = '{0}') s " +
                "INNER JOIN " +
                "(SELECT [礼堂ID],[购买者ID] FROM [票务表]) t " +
                "ON s.学号 = t.购买者ID) st " +
                "INNER JOIN " +
                "(SELECT * FROM [礼堂表] WHERE [开始时间] BETWEEN #{1}# AND #{2}#) a " +
                "ON st.礼堂ID = a.ID ORDER BY [学号] ASC",
                this.txtClassName.Text, BeginDate.ToShortDateString(), EndDate.ToShortDateString());
            string sql3 = string.Format("SELECT LEFT(a.开始时间,10) AS 日期,WeekDay(a.开始时间) AS 星期,Format(a.开始时间,'HH:mm') AS 时间,a.类型,t.数量 FROM " +
                "(SELECT [礼堂ID],COUNT(*) AS 数量 FROM [票务表] " +
                "WHERE [购买者ID] IN(SELECT [学号] FROM [学生表] WHERE [班级名称] = '{0}') " +
                "GROUP BY [礼堂ID]) t " +
                "INNER JOIN " +
                "(SELECT * FROM [礼堂表] WHERE [开始时间] BETWEEN #{1}# AND #{2}#) a " +
                "ON t.礼堂ID = a.ID ORDER BY [a.开始时间] ASC",
                this.txtClassName.Text, BeginDate.ToShortDateString(), EndDate.ToShortDateString());
            try
            {
                this.dataGridView1.DataSource = Access.obj.GetDataTable(sql1);
                DataTable dt2 = Access.obj.GetDataTable(sql2);
                DataTable dt3 = Access.obj.GetDataTable(sql3);
                dt2.Columns.Add("序号");
                dt3.Columns.Add("序号");
                dt2.Columns["序号"].SetOrdinal(0);
                dt3.Columns["序号"].SetOrdinal(0);
                for (int i = 0; i < dt2.Rows.Count; ++i)
                    dt2.Rows[i]["序号"] = i + 1;
                for (int i = 0; i < dt3.Rows.Count; ++i)
                    dt3.Rows[i]["序号"] = i + 1;
                this.dataGridView2.DataSource = dt2;
                this.dataGridView3.DataSource = dt3;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
