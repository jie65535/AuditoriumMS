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
    public partial class FormManageSystem : Form
    {
        public FormManageSystem()
        {
            InitializeComponent();
            this.panelMain.Controls.Add(new UserControls.UCNewAuditorium { Dock = DockStyle.Fill });
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCNewAuditorium { Dock = DockStyle.Fill });
        }

        private void 票务信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCTicketSelect { Dock = DockStyle.Fill });
        }

        private void 票务数量信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCTicketCountSelect { Dock = DockStyle.Fill });
        }

        private void 预订信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCReservationInfoSelect { Dock = DockStyle.Fill });
        }

        private void 票务信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCTicketStatistics { Dock = DockStyle.Fill });
        }

        private void 预订信息统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCTicketCountStatistics { Dock = DockStyle.Fill });
        }

        private void 图形展示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCShowChart { Dock = DockStyle.Fill });
        }

        private void 班级预订汇总ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCSummaryReport { Dock = DockStyle.Fill });
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panelMain.Controls.Clear();
            this.panelMain.Controls.Add(new UserControls.UCModifyPassword { Dock = DockStyle.Fill });
        }

        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
