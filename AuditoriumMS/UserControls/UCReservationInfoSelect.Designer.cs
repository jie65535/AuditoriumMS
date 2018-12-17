namespace AuditoriumMS.UserControls
{
    partial class UCReservationInfoSelect
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
            this.NUDEndMinute = new System.Windows.Forms.NumericUpDown();
            this.NUDBeginMinute = new System.Windows.Forms.NumericUpDown();
            this.NUDEndHour = new System.Windows.Forms.NumericUpDown();
            this.NUDBeginHour = new System.Windows.Forms.NumericUpDown();
            this.DTPEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DTPBeginDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginHour)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // NUDEndMinute
            // 
            this.NUDEndMinute.Location = new System.Drawing.Point(416, 51);
            this.NUDEndMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDEndMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDEndMinute.Name = "NUDEndMinute";
            this.NUDEndMinute.Size = new System.Drawing.Size(38, 23);
            this.NUDEndMinute.TabIndex = 25;
            // 
            // NUDBeginMinute
            // 
            this.NUDBeginMinute.Location = new System.Drawing.Point(148, 51);
            this.NUDBeginMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDBeginMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NUDBeginMinute.Name = "NUDBeginMinute";
            this.NUDBeginMinute.Size = new System.Drawing.Size(40, 23);
            this.NUDBeginMinute.TabIndex = 26;
            // 
            // NUDEndHour
            // 
            this.NUDEndHour.Location = new System.Drawing.Point(347, 51);
            this.NUDEndHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDEndHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NUDEndHour.Name = "NUDEndHour";
            this.NUDEndHour.Size = new System.Drawing.Size(38, 23);
            this.NUDEndHour.TabIndex = 27;
            this.NUDEndHour.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // NUDBeginHour
            // 
            this.NUDBeginHour.Location = new System.Drawing.Point(82, 51);
            this.NUDBeginHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NUDBeginHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NUDBeginHour.Name = "NUDBeginHour";
            this.NUDBeginHour.Size = new System.Drawing.Size(38, 23);
            this.NUDBeginHour.TabIndex = 28;
            this.NUDBeginHour.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // DTPEndDate
            // 
            this.DTPEndDate.Location = new System.Drawing.Point(346, 17);
            this.DTPEndDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DTPEndDate.Name = "DTPEndDate";
            this.DTPEndDate.Size = new System.Drawing.Size(130, 23);
            this.DTPEndDate.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label5.Location = new System.Drawing.Point(457, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "分";
            // 
            // DTPBeginDate
            // 
            this.DTPBeginDate.Location = new System.Drawing.Point(81, 17);
            this.DTPBeginDate.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.DTPBeginDate.Name = "DTPBeginDate";
            this.DTPBeginDate.Size = new System.Drawing.Size(130, 23);
            this.DTPBeginDate.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(386, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "时";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label8.Location = new System.Drawing.Point(194, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(275, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "结束时间：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label7.Location = new System.Drawing.Point(123, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "时";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(275, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "结束日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.Location = new System.Drawing.Point(211, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "<——>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label6.Location = new System.Drawing.Point(10, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "起始时间：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(10, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "起始日期：";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(527, 16);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(147, 23);
            this.txtNumber.TabIndex = 29;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label10.Location = new System.Drawing.Point(483, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "学号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label11.Location = new System.Drawing.Point(695, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "姓名：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(740, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 23);
            this.txtName.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label12.Location = new System.Drawing.Point(482, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "班级：";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(527, 52);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(147, 23);
            this.txtClass.TabIndex = 29;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(760, 44);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(104, 38);
            this.btnSelect.TabIndex = 30;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(3, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 450);
            this.groupBox1.TabIndex = 31;
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(866, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // UCReservationInfoSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.NUDEndMinute);
            this.Controls.Add(this.NUDBeginMinute);
            this.Controls.Add(this.NUDEndHour);
            this.Controls.Add(this.NUDBeginHour);
            this.Controls.Add(this.DTPEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DTPBeginDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UCReservationInfoSelect";
            this.Size = new System.Drawing.Size(884, 534);
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDEndHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDBeginHour)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NUDEndMinute;
        private System.Windows.Forms.NumericUpDown NUDBeginMinute;
        private System.Windows.Forms.NumericUpDown NUDEndHour;
        private System.Windows.Forms.NumericUpDown NUDBeginHour;
        private System.Windows.Forms.DateTimePicker DTPEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DTPBeginDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
