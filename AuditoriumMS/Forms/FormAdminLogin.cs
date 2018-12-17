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
    public partial class FormAdminLogin : Form
    {
        public FormAdminLogin()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string password = txtAdminPassword.Text;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("请输入管理员密码！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                DataTable dt = Access.obj.GetDataTable("SELECT * FROM 管理员密码");
                string adminPassword = dt.Rows[0][0].ToString();
                if (password == adminPassword)
                    this.DialogResult = DialogResult.OK;
                else
                    MessageBox.Show("密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


        }
    }
}
