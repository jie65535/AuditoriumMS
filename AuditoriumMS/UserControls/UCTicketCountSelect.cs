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
    public partial class UCTicketCountSelect : UserControl
    {
        public UCTicketCountSelect()
        {
            InitializeComponent();
        }

        private void UCTicketCountSelect_Load(object sender, EventArgs e)
        {
            string sql = "SELECT a.*, t.购票量, a.票数-t.购票量 as 剩余票数 FROM " +
                "(SELECT [礼堂ID],COUNT(*) as 购票量 FROM [票务表] GROUP BY [礼堂ID]) t" +
                " RIGHT JOIN [礼堂表] a ON t.礼堂ID = a.ID";

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
