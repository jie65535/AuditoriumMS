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
    public partial class UCNewAuditorium : UserControl
    {
        public UCNewAuditorium()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            int totalNumber = 0;
            int price = 0;
            string aType = "";
            DateTime startTIme;
            try
            {
                totalNumber = (int)this.NUDNumber.Value;
                price = (int)this.NUDPrice.Value;
                startTIme = this.DTPStartTIme.Value.Date;
                startTIme = startTIme.AddHours((int)this.NUDHour.Value);
                startTIme = startTIme.AddMinutes((int)this.NUDMinute.Value);
                aType = this.cmbType.Text;
                
                if (string.IsNullOrEmpty(txtTitle.Text))
                {
                    MessageBox.Show("名称不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (Access.IsHasSQLInject(txtTitle.Text))
                {
                    MessageBox.Show("名称禁止输入非法字符！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (startTIme < DateTime.Now)
                {
                    MessageBox.Show("请选择正确的开始时间！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrEmpty(aType))
                {
                    MessageBox.Show("请选择类型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string SQL = string.Format("INSERT INTO 礼堂表(名称,开始时间,类型,票价,票数) VALUES('{0}','{1}','{2}',{3},{4})", txtTitle.Text, startTIme, aType, price, totalNumber);
                int n = Access.obj.Execute(SQL);
                if (n == 1)
                {
                    MessageBox.Show("新建成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("新建失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("处理数据出错，请输入正确的数据！\n错误信息：" + ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void UCNewAuditorium_Load(object sender, EventArgs e)
        {
            this.cmbType.SelectedIndex = 0;
            this.NUDNumber.Maximum = Program.AuditoriumSeatColumnsCount * Program.AuditoriumSeatRowsCount;
        }
    }
}
