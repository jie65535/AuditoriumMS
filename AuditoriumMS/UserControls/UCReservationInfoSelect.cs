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
    public partial class UCReservationInfoSelect : UserControl
    {
        public UCReservationInfoSelect()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            DateTime BeginTime = this.DTPBeginDate.Value.Date;
            BeginTime = BeginTime.AddHours((double)this.NUDBeginHour.Value);
            BeginTime = BeginTime.AddMinutes((double)this.NUDBeginMinute.Value);
            DateTime EndTime = this.DTPEndDate.Value.Date;
            EndTime = EndTime.AddHours((double)this.NUDEndHour.Value);
            EndTime = EndTime.AddMinutes((double)this.NUDEndMinute.Value);

            string name = this.txtName.Text;
            string Class = this.txtClass.Text;
            string number = this.txtNumber.Text;
            if (Access.IsHasSQLInject(name) || Access.IsHasSQLInject(Class) || Access.IsHasSQLInject(number))
            {
                MessageBox.Show("请勿输入敏感词！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!string.IsNullOrEmpty(number))
            {
                try
                {
                    number = string.Format("[学号] = {0}", int.Parse(number));
                }
                catch
                {
                    MessageBox.Show("请输入正确的学号", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
                number = "1=1";
            if (!string.IsNullOrEmpty(Class))
                Class = string.Format("[班级名称] = '{0}'", Class);
            else
                Class = "1=1";
            if (!string.IsNullOrEmpty(name))
                name = string.Format("[姓名] = '{0}'", name);
            else
                name = "1=1";

            string sql = string.Format("SELECT s.*,t.[购票时间],t.[类型] FROM " +
                "(SELECT * FROM [学生表] WHERE {0} AND {1} AND {2})s " +
                "INNER JOIN " +
                "(SELECT * FROM " +
                "(SELECT * FROM [礼堂表] WHERE [票价] = 0 AND [开始时间] Between #{3}# AND #{4}#) a " +
                "INNER JOIN [票务表] t ON a.ID = t.礼堂ID) t" +
                " ON s.[学号] = t.[购买者ID]", 
                number, name, Class, BeginTime, EndTime);
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
