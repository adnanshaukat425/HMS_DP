namespace HMS
{
    partial class main
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
             System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
             this.panel2 = new System.Windows.Forms.Panel();
             this.panel1 = new System.Windows.Forms.Panel();
             this.lbl_user = new System.Windows.Forms.Label();
             this.lbl_username = new System.Windows.Forms.Label();
             this.panel3 = new System.Windows.Forms.Panel();
             this.panel5 = new System.Windows.Forms.Panel();
             this.label2 = new System.Windows.Forms.Label();
             this.lbl_time = new System.Windows.Forms.Label();
             this.menuStrip1 = new System.Windows.Forms.MenuStrip();
             this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.patientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.patientsInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.patientsOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.roomsAndBedsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.labReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.visitingHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.billsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
             this.panel4 = new System.Windows.Forms.Panel();
             this.btn_close_window = new System.Windows.Forms.Button();
             this.pictureBox1 = new System.Windows.Forms.PictureBox();
             this.lbl_head = new System.Windows.Forms.Label();
             this.panel2.SuspendLayout();
             this.panel1.SuspendLayout();
             this.panel3.SuspendLayout();
             this.panel5.SuspendLayout();
             this.menuStrip1.SuspendLayout();
             this.panel4.SuspendLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
             this.SuspendLayout();
             // 
             // panel2
             // 
             this.panel2.BackColor = System.Drawing.Color.Cornsilk;
             this.panel2.Controls.Add(this.panel1);
             this.panel2.Location = new System.Drawing.Point(2, 64);
             this.panel2.Name = "panel2";
             this.panel2.Size = new System.Drawing.Size(399, 35);
             this.panel2.TabIndex = 1;
             // 
             // panel1
             // 
             this.panel1.AutoSize = true;
             this.panel1.BackColor = System.Drawing.SystemColors.Info;
             this.panel1.Controls.Add(this.lbl_user);
             this.panel1.Controls.Add(this.lbl_username);
             this.panel1.Location = new System.Drawing.Point(104, 3);
             this.panel1.Name = "panel1";
             this.panel1.Size = new System.Drawing.Size(200, 29);
             this.panel1.TabIndex = 2;
             // 
             // lbl_user
             // 
             this.lbl_user.AutoSize = true;
             this.lbl_user.Location = new System.Drawing.Point(22, 8);
             this.lbl_user.Name = "lbl_user";
             this.lbl_user.Size = new System.Drawing.Size(54, 13);
             this.lbl_user.TabIndex = 0;
             this.lbl_user.Text = "Login As :";
             this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             this.lbl_user.Click += new System.EventHandler(this.lbl_user_Click);
             // 
             // lbl_username
             // 
             this.lbl_username.AutoSize = true;
             this.lbl_username.Location = new System.Drawing.Point(82, 8);
             this.lbl_username.Name = "lbl_username";
             this.lbl_username.Size = new System.Drawing.Size(0, 13);
             this.lbl_username.TabIndex = 1;
             this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             this.lbl_username.Click += new System.EventHandler(this.lbl_username_Click);
             // 
             // panel3
             // 
             this.panel3.BackColor = System.Drawing.Color.Cornsilk;
             this.panel3.Controls.Add(this.panel5);
             this.panel3.Location = new System.Drawing.Point(399, 64);
             this.panel3.Name = "panel3";
             this.panel3.Size = new System.Drawing.Size(401, 35);
             this.panel3.TabIndex = 2;
             // 
             // panel5
             // 
             this.panel5.AutoSize = true;
             this.panel5.BackColor = System.Drawing.SystemColors.Info;
             this.panel5.Controls.Add(this.label2);
             this.panel5.Controls.Add(this.lbl_time);
             this.panel5.Location = new System.Drawing.Point(101, 3);
             this.panel5.Name = "panel5";
             this.panel5.Size = new System.Drawing.Size(200, 29);
             this.panel5.TabIndex = 2;
             // 
             // label2
             // 
             this.label2.AutoSize = true;
             this.label2.Location = new System.Drawing.Point(15, 8);
             this.label2.Name = "label2";
             this.label2.Size = new System.Drawing.Size(65, 13);
             this.label2.TabIndex = 0;
             this.label2.Text = "Login Time :";
             this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             // 
             // lbl_time
             // 
             this.lbl_time.AutoSize = true;
             this.lbl_time.Location = new System.Drawing.Point(86, 8);
             this.lbl_time.Name = "lbl_time";
             this.lbl_time.Size = new System.Drawing.Size(0, 13);
             this.lbl_time.TabIndex = 1;
             this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             this.lbl_time.Click += new System.EventHandler(this.lbl_time_Click);
             // 
             // menuStrip1
             // 
             this.menuStrip1.AutoSize = false;
             this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
             this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
             this.menuStrip1.Enabled = false;
             this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.doctorsToolStripMenuItem,
            this.patientsToolStripMenuItem,
            this.roomsAndBedsToolStripMenuItem,
            this.labReportsToolStripMenuItem,
            this.visitingHistoryToolStripMenuItem,
            this.billsToolStripMenuItem,
            this.logoutToolStripMenuItem});
             this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
             this.menuStrip1.Location = new System.Drawing.Point(2, 32);
             this.menuStrip1.Name = "menuStrip1";
             this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
             this.menuStrip1.Size = new System.Drawing.Size(798, 32);
             this.menuStrip1.TabIndex = 6;
             this.menuStrip1.Text = "menuStrip1";
             this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
             // 
             // fileToolStripMenuItem
             // 
             this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newUserToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
             this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
             this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 28);
             this.fileToolStripMenuItem.Text = "File";
             this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
             // 
             // newUserToolStripMenuItem
             // 
             this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
             this.newUserToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
             this.newUserToolStripMenuItem.Text = "New User";
             this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
             // 
             // aboutUsToolStripMenuItem
             // 
             this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
             this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
             this.aboutUsToolStripMenuItem.Text = "About Us";
             this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click_1);
             // 
             // exitToolStripMenuItem
             // 
             this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
             this.exitToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
             this.exitToolStripMenuItem.Text = "Exit";
             this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
             // 
             // doctorsToolStripMenuItem
             // 
             this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
             this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(60, 28);
             this.doctorsToolStripMenuItem.Text = "Doctors";
             this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
             // 
             // patientsToolStripMenuItem
             // 
             this.patientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientsInToolStripMenuItem,
            this.patientsOutToolStripMenuItem});
             this.patientsToolStripMenuItem.Name = "patientsToolStripMenuItem";
             this.patientsToolStripMenuItem.Size = new System.Drawing.Size(61, 28);
             this.patientsToolStripMenuItem.Text = "Patients";
             this.patientsToolStripMenuItem.Click += new System.EventHandler(this.patientsToolStripMenuItem_Click);
             this.patientsToolStripMenuItem.MouseHover += new System.EventHandler(this.patientsToolStripMenuItem_MouseHover);
             // 
             // patientsInToolStripMenuItem
             // 
             this.patientsInToolStripMenuItem.Name = "patientsInToolStripMenuItem";
             this.patientsInToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
             this.patientsInToolStripMenuItem.Text = "Patients In";
             this.patientsInToolStripMenuItem.Click += new System.EventHandler(this.patientsInToolStripMenuItem_Click);
             // 
             // patientsOutToolStripMenuItem
             // 
             this.patientsOutToolStripMenuItem.Name = "patientsOutToolStripMenuItem";
             this.patientsOutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
             this.patientsOutToolStripMenuItem.Text = "Patients Out";
             this.patientsOutToolStripMenuItem.Click += new System.EventHandler(this.patientsOutToolStripMenuItem_Click);
             // 
             // roomsAndBedsToolStripMenuItem
             // 
             this.roomsAndBedsToolStripMenuItem.Name = "roomsAndBedsToolStripMenuItem";
             this.roomsAndBedsToolStripMenuItem.Size = new System.Drawing.Size(109, 28);
             this.roomsAndBedsToolStripMenuItem.Text = "Rooms And Beds";
             this.roomsAndBedsToolStripMenuItem.Click += new System.EventHandler(this.roomsAndBedsToolStripMenuItem_Click);
             // 
             // labReportsToolStripMenuItem
             // 
             this.labReportsToolStripMenuItem.Name = "labReportsToolStripMenuItem";
             this.labReportsToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
             this.labReportsToolStripMenuItem.Text = "Lab Reports";
             this.labReportsToolStripMenuItem.Click += new System.EventHandler(this.labReportsToolStripMenuItem_Click);
             // 
             // visitingHistoryToolStripMenuItem
             // 
             this.visitingHistoryToolStripMenuItem.Name = "visitingHistoryToolStripMenuItem";
             this.visitingHistoryToolStripMenuItem.Size = new System.Drawing.Size(99, 28);
             this.visitingHistoryToolStripMenuItem.Text = "Visiting History";
             this.visitingHistoryToolStripMenuItem.Click += new System.EventHandler(this.visitingHistoryToolStripMenuItem_Click);
             // 
             // billsToolStripMenuItem
             // 
             this.billsToolStripMenuItem.Name = "billsToolStripMenuItem";
             this.billsToolStripMenuItem.Size = new System.Drawing.Size(40, 28);
             this.billsToolStripMenuItem.Text = "Bills";
             this.billsToolStripMenuItem.Click += new System.EventHandler(this.billsToolStripMenuItem_Click);
             // 
             // logoutToolStripMenuItem
             // 
             this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
             this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 28);
             this.logoutToolStripMenuItem.Text = "Logout";
             this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
             // 
             // panel4
             // 
             this.panel4.BackColor = System.Drawing.Color.Firebrick;
             this.panel4.Controls.Add(this.btn_close_window);
             this.panel4.Controls.Add(this.pictureBox1);
             this.panel4.Controls.Add(this.lbl_head);
             this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
             this.panel4.ForeColor = System.Drawing.SystemColors.Info;
             this.panel4.Location = new System.Drawing.Point(0, 0);
             this.panel4.Name = "panel4";
             this.panel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
             this.panel4.Size = new System.Drawing.Size(800, 35);
             this.panel4.TabIndex = 8;
             this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
             // 
             // btn_close_window
             // 
             this.btn_close_window.DialogResult = System.Windows.Forms.DialogResult.Cancel;
             this.btn_close_window.FlatAppearance.BorderSize = 0;
             this.btn_close_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
             this.btn_close_window.ForeColor = System.Drawing.SystemColors.Info;
             this.btn_close_window.Location = new System.Drawing.Point(764, 0);
             this.btn_close_window.Name = "btn_close_window";
             this.btn_close_window.Size = new System.Drawing.Size(36, 35);
             this.btn_close_window.TabIndex = 6;
             this.btn_close_window.Text = "X";
             this.btn_close_window.UseVisualStyleBackColor = true;
             this.btn_close_window.Click += new System.EventHandler(this.btn_close_window_Click);
             // 
             // pictureBox1
             // 
             this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
             this.pictureBox1.Location = new System.Drawing.Point(3, 4);
             this.pictureBox1.Name = "pictureBox1";
             this.pictureBox1.Size = new System.Drawing.Size(35, 30);
             this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
             this.pictureBox1.TabIndex = 3;
             this.pictureBox1.TabStop = false;
             // 
             // lbl_head
             // 
             this.lbl_head.AutoSize = true;
             this.lbl_head.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
             this.lbl_head.Location = new System.Drawing.Point(240, 4);
             this.lbl_head.Name = "lbl_head";
             this.lbl_head.Size = new System.Drawing.Size(324, 25);
             this.lbl_head.TabIndex = 2;
             this.lbl_head.Text = "Hospital Management System";
             this.lbl_head.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
             // 
             // main
             // 
             this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
             this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
             this.BackColor = System.Drawing.SystemColors.Window;
             this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
             this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
             this.ClientSize = new System.Drawing.Size(800, 361);
             this.Controls.Add(this.panel4);
             this.Controls.Add(this.menuStrip1);
             this.Controls.Add(this.panel3);
             this.Controls.Add(this.panel2);
             this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
             this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
             this.IsMdiContainer = true;
             this.MainMenuStrip = this.menuStrip1;
             this.Name = "main";
             this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
             this.Text = "Hospital Management System";
             this.Load += new System.EventHandler(this.main_Load);
             this.panel2.ResumeLayout(false);
             this.panel2.PerformLayout();
             this.panel1.ResumeLayout(false);
             this.panel1.PerformLayout();
             this.panel3.ResumeLayout(false);
             this.panel3.PerformLayout();
             this.panel5.ResumeLayout(false);
             this.panel5.PerformLayout();
             this.menuStrip1.ResumeLayout(false);
             this.menuStrip1.PerformLayout();
             this.panel4.ResumeLayout(false);
             this.panel4.PerformLayout();
             ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
             this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientsOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomsAndBedsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitingHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billsToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button btn_close_window;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
    }
}