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
    public partial class UCBooking : UserControl
    {
        public UCBooking()
        {
            InitializeComponent();
            // 座位被选中事件
            this.ucSeatMap1.SelectedEvent += UcSeatMap1_SelectedEvent;
        }

        private void UcSeatMap1_SelectedEvent(object sender, Point point)
        {
            if (this.ID == 0)
                return;
            Booking(point);
        }
        #region 属性
        private int _ID;
        public int ID
        {
            set
            {
                _ID = value;
                this.UpdateInfo(value);
            }
            get
            {
                return _ID;
            }
        }
        
        private string Title
        {
            get
            {
                return this.lblTitle.Text;
            }
            set
            {
                this.lblTitle.Text = value;
            }
        }
        private DateTime _startTIme;
        private DateTime StartTIme
        {
            get
            {
                return _startTIme;
            }
            set
            {
                _startTIme = value;
                this.lblDate.Text = string.Format("{0} {1}",
                    value.ToString("yyyy-MM-dd"),
                    value.DayOfWeek);
                this.lblTime.Text = value.ToString("HH:mm");
            }
        }
        private string _type;
        private string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }
        private int _price;
        private int Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
                if (value == 0)
                {
                    this.lblPrice.Text = "免费";
                    this.lblPrompt.Visible = true;
                }
                else
                {
                    this.lblPrice.Text = string.Format("{0}元", value);
                    this.lblPrompt.Visible = false;
                }
            }
        }
        private int _total;
        private int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                this.lblTotal.Text = value.ToString();
            }
        }
        private int _count;
        private int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                this.lblRemaining.Text = (Total - value).ToString();
            }
        }
        #endregion

        private bool[,] seatMap;

        /// <summary>
        /// 更新显示信息
        /// </summary>
        /// <param name="id">场次ID</param>
        private void UpdateInfo(int id)
        {
            if (id == 0) return;
            try
            {
                string sql = string.Format("SELECT * FROM 礼堂表 WHERE ID={0}", id);
                DataTable dt = Access.obj.GetDataTable(sql);
                if (dt == null || dt.Rows.Count < 1)
                {
                    MessageBox.Show("未获取到数据！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Title = dt.Rows[0]["名称"].ToString();
                this.StartTIme = Convert.ToDateTime(dt.Rows[0]["开始时间"]);
                this.Price = Convert.ToInt32(dt.Rows[0]["票价"]);
                this.Type = dt.Rows[0]["类型"].ToString();
                this.Total = Convert.ToInt32(dt.Rows[0]["票数"]);


                sql = string.Format("SELECT 排,列 FROM 票务表 WHERE 礼堂ID={0}", id);
                DataTable seatDT = Access.obj.GetDataTable(sql);
                this.seatMap = new bool[Program.AuditoriumSeatRowsCount, Program.AuditoriumSeatColumnsCount];
                for (int i = 0; i < Program.AuditoriumSeatRowsCount; ++i)
                    for (int j = 0; j < Program.AuditoriumSeatColumnsCount; ++j)
                        seatMap[i,j] = false;

                this.Count = seatDT.Rows.Count;
                List <Point> seatList = new List<Point>();
                foreach (DataRow row in seatDT.Rows)
                {
                    Point p = new Point(Convert.ToInt32(row["排"]), Convert.ToInt32(row["列"]));
                    seatMap[p.X - 1, p.Y - 1] = true;
                    seatList.Add(p);
                }

                this.ucSeatMap1.SetValue(seatList, Convert.ToInt32(dt.Rows[0]["票数"]));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private bool Booking(Point point)
        {
            if (point.X == 0)
                return false;
            int id = 0;
            
            // 免费为对校内开放，需要提供实名认证
            if (this.Price == 0)
            {
                Forms.FormVerift formVerift = new Forms.FormVerift();
                if (formVerift.ShowDialog() == DialogResult.OK)
                {
                    id = Convert.ToInt32(formVerift.Tag);
                    string sql = string.Format("SELECT 排,列,购票时间 FROM 票务表 WHERE 购买者ID={0} AND 礼堂ID={1}",
                        id, this.ID);
                    try
                    {
                        DataTable dt = Access.obj.GetDataTable(sql);
                        if (dt != null && dt.Rows.Count > 0)
                        {
                            MessageBox.Show(string.Format("你在{0}已经买过本场的票，座位号：{1:00}-{2:00}",
                                Convert.ToDateTime(dt.Rows[0]["购票时间"]).ToString("yyyy-MM-dd HH:mm"),
                                dt.Rows[0]["排"], dt.Rows[0]["列"]), "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    return false;
                }
            }
            InsertTicketInfo(point, id);
            UpdateInfo(this.ID);

            // 每张票上的信息包括日期(年、月、日)、星期、时间(时、分)、排、号、类型、票价、编号，以及“名家礼堂”这一固定名称。
            MessageBox.Show(string.Format("订票成功，座位号为：{0:00}-{1:00}", point.X, point.Y), "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PrintTicket(point);
            return true;
        }

        /// <summary>
        /// 打印票据
        /// </summary>
        /// <param name="point">座位坐标</param>
        private void PrintTicket(Point point)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "票据文件|*.txt";
            if (MessageBox.Show("请问是否打印票据信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            if (save.ShowDialog() != DialogResult.OK)
                return;
            string savePath = save.FileName;
            using (System.IO.FileStream file = new System.IO.FileStream(savePath, System.IO.FileMode.Create, System.IO.FileAccess.Write))
            {
                using (System.IO.TextWriter text = new System.IO.StreamWriter(file, System.Text.Encoding.Default))
                {
                    text.Write(string.Format("日期：{0}\t星期：{1}\t时间：{2}\t排：{3}\t号：{4}\t类型：{5}\t票价：{6}\t编号：{7}\t名称：{8}",
                        this.StartTIme.ToShortDateString(), this.StartTIme.DayOfWeek, this.StartTIme.ToShortTimeString(),
                        point.X, point.Y, this.Type, this.Price, this.ID, this.Title));
                }
            }
        }

        /// <summary>
        /// 插入票据信息
        /// </summary>
        /// <param name="p">座位</param>
        /// <param name="id">购买者ID（外来人为0）</param>
        private void InsertTicketInfo(Point p, int id)
        {
            string sql = string.Format("INSERT INTO 票务表(排,列,礼堂ID,购买者ID) VALUES({0}, {1}, {2}, {3})", p.X, p.Y, this.ID, id);
            try
            {
                int n = Access.obj.Execute(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 寻找空座位
        /// </summary>
        /// <returns>空位坐标</returns>
        private Point FindVacancy()
        {
            for (int i = 0; i < Program.AuditoriumSeatRowsCount; ++i)
                for (int j = 0; j < Program.AuditoriumSeatColumnsCount; ++j)
                    if (this.seatMap[i, j] == false)
                        return new Point(i + 1, j + 1);
            return new Point(0, 0);
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (this.ID == 0)
                return;

            if (this.Count == this.Total)
            {
                MessageBox.Show("没有余票", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Booking(FindVacancy());
        }
    }
}
