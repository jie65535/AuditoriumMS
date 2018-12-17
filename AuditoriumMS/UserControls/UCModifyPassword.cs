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
    public partial class UCModifyPassword : UserControl
    {
        public UCModifyPassword()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtOldPassword.Text) 
                || string.IsNullOrEmpty(this.txtNewPassword.Text)
                || string.IsNullOrEmpty(this.txtNewPassword1.Text))
            {
                MessageBox.Show("不能为空！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Access.IsHasSQLInject(this.txtOldPassword.Text)
                || Access.IsHasSQLInject(this.txtNewPassword.Text)
                || Access.IsHasSQLInject(this.txtNewPassword1.Text))
            {
                MessageBox.Show("禁止输入非法字符！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.txtNewPassword.Text != this.txtNewPassword1.Text)
            {
                MessageBox.Show("两次密码不相同！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = string.Format("UPDATE 管理员密码 SET [密码]='{0}' WHERE [密码]='{1}'",
                this.txtNewPassword.Text, this.txtOldPassword.Text);
            try
            {
                int n = Access.obj.Execute(sql);
                if (n == 0)
                {
                    MessageBox.Show("旧密码错误，修改失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    this.txtNewPassword.Text = "";
                    this.txtNewPassword1.Text = "";
                    this.txtOldPassword.Text = "";
                    MessageBox.Show("密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
