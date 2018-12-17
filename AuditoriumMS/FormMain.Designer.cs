namespace AuditoriumMS
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnManagement = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLecture = new System.Windows.Forms.TabPage();
            this.treeLecture = new System.Windows.Forms.TreeView();
            this.tabPageMovie = new System.Windows.Forms.TabPage();
            this.treeMovie = new System.Windows.Forms.TreeView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBooking = new AuditoriumMS.UserControls.UCBooking();
            this.tabControl1.SuspendLayout();
            this.tabPageLecture.SuspendLayout();
            this.tabPageMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManagement
            // 
            this.btnManagement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManagement.Location = new System.Drawing.Point(1182, 13);
            this.btnManagement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManagement.Name = "btnManagement";
            this.btnManagement.Size = new System.Drawing.Size(104, 30);
            this.btnManagement.TabIndex = 1;
            this.btnManagement.Text = "管理";
            this.btnManagement.UseVisualStyleBackColor = true;
            this.btnManagement.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tabControl1.Controls.Add(this.tabPageLecture);
            this.tabControl1.Controls.Add(this.tabPageMovie);
            this.tabControl1.Location = new System.Drawing.Point(12, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(186, 616);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageLecture
            // 
            this.tabPageLecture.Controls.Add(this.treeLecture);
            this.tabPageLecture.Location = new System.Drawing.Point(4, 26);
            this.tabPageLecture.Name = "tabPageLecture";
            this.tabPageLecture.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLecture.Size = new System.Drawing.Size(178, 586);
            this.tabPageLecture.TabIndex = 0;
            this.tabPageLecture.Text = "讲座";
            this.tabPageLecture.UseVisualStyleBackColor = true;
            // 
            // treeLecture
            // 
            this.treeLecture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeLecture.Location = new System.Drawing.Point(3, 3);
            this.treeLecture.Name = "treeLecture";
            this.treeLecture.Size = new System.Drawing.Size(172, 580);
            this.treeLecture.TabIndex = 0;
            this.treeLecture.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // tabPageMovie
            // 
            this.tabPageMovie.Controls.Add(this.treeMovie);
            this.tabPageMovie.Location = new System.Drawing.Point(4, 26);
            this.tabPageMovie.Name = "tabPageMovie";
            this.tabPageMovie.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMovie.Size = new System.Drawing.Size(178, 586);
            this.tabPageMovie.TabIndex = 1;
            this.tabPageMovie.Text = "电影";
            this.tabPageMovie.UseVisualStyleBackColor = true;
            // 
            // treeMovie
            // 
            this.treeMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeMovie.Location = new System.Drawing.Point(3, 3);
            this.treeMovie.Name = "treeMovie";
            this.treeMovie.Size = new System.Drawing.Size(172, 580);
            this.treeMovie.TabIndex = 0;
            this.treeMovie.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 13);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "刷新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBooking
            // 
            this.btnBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBooking.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBooking.ID = 0;
            this.btnBooking.Location = new System.Drawing.Point(200, 51);
            this.btnBooking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBooking.Name = "btnBooking";
            this.btnBooking.Size = new System.Drawing.Size(1086, 578);
            this.btnBooking.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1298, 645);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBooking);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnManagement);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "培优礼堂票务管理系统";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageLecture.ResumeLayout(false);
            this.tabPageMovie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnManagement;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLecture;
        private System.Windows.Forms.TreeView treeLecture;
        private System.Windows.Forms.TabPage tabPageMovie;
        private System.Windows.Forms.TreeView treeMovie;
        private UserControls.UCBooking btnBooking;
        private System.Windows.Forms.Button btnUpdate;
    }
}