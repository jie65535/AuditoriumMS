namespace AuditoriumMS.UserControls
{
    partial class UCTicketSelect
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.NUDBeginMinute = new System.Windows.Forms.NumericUpDown();
            this.NUDBeginHour = new System.Windows.Forms.NumericUpDown();
            this.DTPBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.NUDEndHour = new System.Windows.Forms.NumericUpDown();
            this.NUDEndMinute = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndMinute)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDBeginMinute
            // 
            this.NUDBeginMinute.Location = new System.Drawing.Point(205, 66);
            this.NUDBeginMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDBeginMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDBeginMinute.Name = "NUDBeginMinute";
            this.NUDBeginMinute.Size = new System.Drawing.Size(62, 23);
            this.NUDBeginMinute.TabIndex = 12;
            // 
            // NUDBeginHour
            // 
            this.NUDBeginHour.Location = new System.Drawing.Point(98, 66);
            this.NUDBeginHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDBeginHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NUDBeginHour.Name = "NUDBeginHour";
            this.NUDBeginHour.Size = new System.Drawing.Size(62, 23);
            this.NUDBeginHour.TabIndex = 13;
            this.NUDBeginHour.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // DTPBeginDate
            // 
            this.DTPBeginDate.Location = new System.Drawing.Point(97, 22);
            this.DTPBeginDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DTPBeginDate.Name = "DTPBeginDate";
            this.DTPBeginDate.Size = new System.Drawing.Size(209, 23);
            this.DTPBeginDate.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.Location = new System.Drawing.Point(274, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 21);
            this.label8.TabIndex = 7;
            this.label8.Text = "分";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.Location = new System.Drawing.Point(167, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 21);
            this.label7.TabIndex = 8;
            this.label7.Text = "时";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.Location = new System.Drawing.Point(12, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "起始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "起始日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label1.Location = new System.Drawing.Point(386, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "结束日期：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(386, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "结束时间：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.Location = new System.Drawing.Point(543, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "时";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.Location = new System.Drawing.Point(651, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "分";
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Location = new System.Drawing.Point(473, 23);
            this.DTPEndDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(209, 23);
            this.DTPEndDate.TabIndex = 11;
            // 
            // NUDEndHour
            // 
            this.NUDEndHour.Location = new System.Drawing.Point(474, 67);
            this.NUDEndHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDEndHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NUDEndHour.Name = "NUDEndHour";
            this.NUDEndHour.Size = new System.Drawing.Size(62, 23);
            this.NUDEndHour.TabIndex = 13;
            this.NUDEndHour.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // NUDEndMinute
            // 
            this.NUDEndMinute.Location = new System.Drawing.Point(582, 67);
            this.NUDEndMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDEndMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDEndMinute.Name = "NUDEndMinute";
            this.NUDEndMinute.Size = new System.Drawing.Size(62, 23);
            this.NUDEndMinute.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.Location = new System.Drawing.Point(312, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 9;
            this.label9.Text = "<——>";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 98);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(878, 432);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询结果";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(866, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(710, 61);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(167, 36);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label10.Location = new System.Drawing.Point(706, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "类型：";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "全部",
            "讲座",
            "电影"});
            this.cmbType.Location = new System.Drawing.Point(753, 21);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(86, 25);
            this.cmbType.TabIndex = 16;
            // 
            // UCTicketSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NUDEndMinute);
            this.Controls.Add(this.NUDBeginMinute);
            this.Controls.Add(this.NUDEndHour);
            this.Controls.Add(this.NUDBeginHour);
            this.Controls.Add(this.DTPEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPBeginDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCTicketSelect";
            this.Size = new System.Drawing.Size(884, 534);
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndMinute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDBeginMinute;
        private System.Windows.Forms.NumericUpDown NUDBeginHour;
        private System.Windows.Forms.DateTimePicker DTPBeginDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.NumericUpDown NUDEndHour;
        private System.Windows.Forms.NumericUpDown NUDEndMinute;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbType;
    }
}
