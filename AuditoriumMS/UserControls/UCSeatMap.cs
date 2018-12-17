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
    public partial class UCSeatMap : UserControl
    {
        public UCSeatMap()
        {
            InitializeComponent();

        }
        /// <summary>
        /// 是否已经初始化
        /// </summary>
        private bool isInit = false;
        private void InitializerSeatMap()
        {
            System.Threading.Thread t = new System.Threading.Thread(() =>
            {
                this.Invoke(new Action(() => { FLPMap.SuspendLayout(); }));
                Label lblSeat = new Label();
                for (int row = 1; row <= Program.AuditoriumSeatRowsCount; ++row)
                {
                    for (int col = 1; col <= Program.AuditoriumSeatColumnsCount; ++col)
                    {
                        lblSeat = new Label();
                        lblSeat.Text = string.Format("{0:00}-{1:00}", row, col);
                        lblSeat.Name = lblSeat.Text;
                        lblSeat.AutoSize = true;
                        lblSeat.Margin = new Padding(6);
                        lblSeat.Tag = new Point(row, col);
                        lblSeat.Cursor = Cursors.Hand;
                        lblSeat.Click += LblSeat_Click;
                        this.Invoke(new Action(() => { FLPMap.Controls.Add(lblSeat); }));
                    }
                    this.Invoke(new Action(() => { FLPMap.SetFlowBreak(lblSeat, true); }));
                }
                this.isInit = true;
                this.Invoke(new Action(() => { FLPMap.ResumeLayout(); }));
            });
            t.Start();
        }

        public delegate void SelectedEventHandler(object sender, Point point);
        /// <summary>
        /// 座位选中事件
        /// </summary>
        public event SelectedEventHandler SelectedEvent;
        // 发出座位被选中的事件
        private void LblSeat_Click(object sender, EventArgs e)
        {
            Label lblSeat = sender as Label;
            // 如果颜色不是可以选的颜色，则直接返回
            if (lblSeat.BackColor != Color.FromArgb(0x66, 0xFF, 0xCC))
                return;
            if (SelectedEvent != null)
                SelectedEvent(sender, (Point)(sender as Label).Tag);
        }

        /// <summary>
        /// 设置座位值
        /// </summary>
        /// <param name="soldList">售出的座位</param>
        /// <param name="max">总数量</param>
        public void SetValue(List<Point> soldList, int max)
        {
            while (!this.isInit)
                ; // 等待初始化完毕
            FLPMap.SuspendLayout();
            for (int i = 0; i < this.FLPMap.Controls.Count; ++i)
            {
                Label lblSeat = FLPMap.Controls[i] as Label;
                if (i < max)
                {
                    lblSeat.Cursor = Cursors.Hand;
                    lblSeat.ForeColor = Color.FromArgb(0x00, 0x00, 0x00);
                    lblSeat.BackColor = Color.FromArgb(0x66, 0xFF, 0xCC);
                }
                else
                {
                    // 如果是无法选择的座位，则取消事件
                    lblSeat.Cursor = Cursors.Default;
                    lblSeat.ForeColor = Color.FromArgb(0x99, 0x99, 0x99);
                    lblSeat.BackColor = Color.FromArgb(0xcc, 0xcc, 0xcc);
                }
            }

            foreach (var p in soldList)
            {
                string name = string.Format("{0:00}-{1:00}", p.X, p.Y);
                var c = FLPMap.Controls.Find(name, false);
                if (c != null && c.Length > 0)
                {
                    Label lblSeat = c[0] as Label;
                    // 如果是无法选择的座位，则取消事件
                    lblSeat.Cursor = Cursors.Default;
                    lblSeat.ForeColor = Color.FromArgb(0x00, 0x00, 0x00);
                    lblSeat.BackColor = Color.FromArgb(0xFF, 0xCC, 0x66);
                }
            }
            FLPMap.ResumeLayout();
        }

        public void setValue(Point point)
        {
            string key = string.Format("{0:00}-{1:00}", point.X, point.Y);
            var c = FLPMap.Controls.Find(key, false);
            if (c != null && c.Length > 0)
            {
                Label lblSeat = c[0] as Label;
                lblSeat.ForeColor = Color.FromArgb(0x00, 0x00, 0x00);
                lblSeat.BackColor = Color.FromArgb(0xFF, 0xCC, 0x66);
            }
        }

        private void UCSeatMap_Load(object sender, EventArgs e)
        {
            InitializerSeatMap();
        }
    }
}
