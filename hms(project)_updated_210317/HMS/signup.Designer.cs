namespace HMS
{
    partial class signup
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wrapper = new System.Windows.Forms.Panel();
            this.lbl_con_pass = new System.Windows.Forms.Label();
            this.txt_con_pass = new System.Windows.Forms.TextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_signup = new System.Windows.Forms.Button();
            this.heading = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_head = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_close_window = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.wrapper.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 22);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // wrapper
            // 
            this.wrapper.BackColor = System.Drawing.SystemColors.HighlightText;
            this.wrapper.Controls.Add(this.lbl_con_pass);
            this.wrapper.Controls.Add(this.txt_con_pass);
            this.wrapper.Controls.Add(this.btn_reset);
            this.wrapper.Controls.Add(this.btn_signup);
            this.wrapper.Controls.Add(this.heading);
            this.wrapper.Controls.Add(this.label4);
            this.wrapper.Controls.Add(this.label2);
            this.wrapper.Controls.Add(this.txt_password);
            this.wrapper.Controls.Add(this.txt_username);
            this.wrapper.Location = new System.Drawing.Point(20, 20);
            this.wrapper.Name = "wrapper";
            this.wrapper.Padding = new System.Windows.Forms.Padding(10, 20, 20, 20);
            this.wrapper.Size = new System.Drawing.Size(326, 240);
            this.wrapper.TabIndex = 2;
            // 
            // lbl_con_pass
            // 
            this.lbl_con_pass.AutoSize = true;
            this.lbl_con_pass.Location = new System.Drawing.Point(36, 137);
            this.lbl_con_pass.Name = "lbl_con_pass";
            this.lbl_con_pass.Size = new System.Drawing.Size(91, 13);
            this.lbl_con_pass.TabIndex = 7;
            this.lbl_con_pass.Text = "Confirm Password";
            // 
            // txt_con_pass
            // 
            this.txt_con_pass.Location = new System.Drawing.Point(132, 134);
            this.txt_con_pass.Name = "txt_con_pass";
            this.txt_con_pass.PasswordChar = '*';
            this.txt_con_pass.Size = new System.Drawing.Size(171, 20);
            this.txt_con_pass.TabIndex = 8;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Chocolate;
            this.btn_reset.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_reset.Location = new System.Drawing.Point(218, 171);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.Chocolate;
            this.btn_signup.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_signup.Location = new System.Drawing.Point(137, 171);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(75, 23);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = false;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Location = new System.Drawing.Point(13, 32);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(95, 13);
            this.heading.TabIndex = 2;
            this.heading.Text = "New User Sign Up";
            this.heading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(132, 106);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(171, 20);
            this.txt_password.TabIndex = 2;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(132, 79);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(171, 20);
            this.txt_username.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 262);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(371, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_status
            // 
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(39, 17);
            this.lbl_status.Text = "Ready";
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.Location = new System.Drawing.Point(27, 9);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(45, 13);
            this.lbl_head.TabIndex = 2;
            this.lbl_head.Text = "Sign Up";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Firebrick;
            this.panel2.Controls.Add(this.btn_close_window);
            this.panel2.Controls.Add(this.btn_close);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.lbl_head);
            this.panel2.ForeColor = System.Drawing.SystemColors.Info;
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(374, 29);
            this.panel2.TabIndex = 7;
            // 
            // btn_close_window
            // 
            this.btn_close_window.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close_window.FlatAppearance.BorderSize = 0;
            this.btn_close_window.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close_window.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_close_window.Location = new System.Drawing.Point(337, -1);
            this.btn_close_window.Name = "btn_close_window";
            this.btn_close_window.Size = new System.Drawing.Size(37, 30);
            this.btn_close_window.TabIndex = 5;
            this.btn_close_window.Text = "X";
            this.btn_close_window.UseVisualStyleBackColor = true;
            this.btn_close_window.Click += new System.EventHandler(this.btn_close_window_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Firebrick;
            this.btn_close.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_close.Location = new System.Drawing.Point(492, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(38, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.wrapper);
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Location = new System.Drawing.Point(1, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 284);
            this.panel1.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 310);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "signup";
            this.Load += new System.EventHandler(this.signup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.wrapper.ResumeLayout(false);
            this.wrapper.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_status;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_close_window;
        private System.Windows.Forms.Label lbl_con_pass;
        private System.Windows.Forms.TextBox txt_con_pass;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}