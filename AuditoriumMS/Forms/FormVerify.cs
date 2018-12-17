using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuditoriumMS.Forms
{
    public partial class FormVerift : Form
    {
        public FormVerift()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtNumber.Text))
            {
                MessageBox.Show("请输入学号！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.txtName.Text))
            {
                MessageBox.Show("请输入姓名！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // SQL防注入
            if (Access.IsHasSQLInject(this.txtNumber.Text)
                || Access.IsHasSQLInject(this.txtName.Text))
            {
                MessageBox.Show("格式错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = string.Format("SELECT 1 FROM [学生表] WHERE [学号]={0} AND [姓名]='{1}'",
                this.txtNumber.Text, this.txtName.Text);
            try
            {
                DataTable dt = Access.obj.GetDataTable(sql);
                if (dt == null || dt.Rows.Count < 1)
                {
                    MessageBox.Show("无该学生！请输入正确的信息", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                // 用来返回购票学生学号
                this.Tag = this.txtNumber.Text;
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
