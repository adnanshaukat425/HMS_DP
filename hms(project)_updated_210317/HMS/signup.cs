using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HMS
{
    public partial class signup : Form
    {
        signup_user obj_su = new signup_user();

        public signup()
        {
            InitializeComponent();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            obj_su.sign_up(txt_username, txt_password, txt_con_pass, errorProvider1, lbl_status);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            obj_su.cleartext(txt_username,txt_password,txt_con_pass);
        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        void set_form()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 90;
            this.Location = new Point(15, this.Top);
            this.Font = new Font("Microsoft Sans Serif", 9);
        }

        private void signup_Load(object sender, EventArgs e)
        {
            set_form();
        }
    }
}
