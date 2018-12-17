using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AuditoriumMS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            Forms.FormAdminLogin form = new Forms.FormAdminLogin();
            if (form.ShowDialog() == DialogResult.OK)
            {
                FormManageSystem formManageSystem = new FormManageSystem();
                formManageSystem.ShowDialog();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateAuditoriumInfo();
        }

        /// <summary>
        /// 更新礼堂信息
        /// </summary>
        private void UpdateAuditoriumInfo()
        {
            try
            {
                treeLecture.Nodes.Clear();
                treeMovie.Nodes.Clear();
                DataTable dt = Access.obj.GetDataTable("SELECT ID,名称,开始时间,类型 FROM 礼堂表 WHERE 开始时间 > now() ORDER BY 开始时间");
                // 遍历每一场
                foreach (DataRow row in dt.Rows)
                {
                    string nodeText = string.Format("{0} {1}",
                        Convert.ToDateTime(row["开始时间"]).ToString("HH:mm"),
                        row["名称"]);
                    TreeNode node = new TreeNode(nodeText);
                    node.Name = node.Text;
                    node.Tag = row["ID"];
                    DateTime startTime = Convert.ToDateTime(row["开始时间"]);
                    string DateKey = string.Format("{0} {1}", startTime.ToString("yyyy-MM-dd"), startTime.DayOfWeek);
                    // DateTime.Now.DayOfWeek
                    if (row["类型"].ToString() == "讲座")
                    {
                        // 如果没有这一场的日期，则添加一个日期节点
                        if (!treeLecture.Nodes.ContainsKey(DateKey))
                        {
                            TreeNode PNode = new TreeNode(DateKey);
                            PNode.Name = DateKey;
                            treeLecture.Nodes.Add(PNode);
                        }
                        treeLecture.Nodes[DateKey].Nodes.Add(node);
                    }
                    else
                    {
                        // 如果没有这一场的日期，则添加一个日期节点
                        if (!treeMovie.Nodes.ContainsKey(DateKey))
                        {
                            TreeNode PNode = new TreeNode(DateKey);
                            PNode.Name = DateKey;
                            treeMovie.Nodes.Add(PNode);
                        }
                        treeMovie.Nodes[DateKey].Nodes.Add(node);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        
        private void treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag == null)
                return;

            this.btnBooking.ID = Convert.ToInt32(e.Node.Tag);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAuditoriumInfo();
        }
    }
}
