using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    public partial class login : Form
    {
        //login_access obj_login = new login_access();
        LoginAccessManager loginAccessManager = new LoginAccessManager();
        public login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void set_login()
        {
            wrapper.Location = new Point((this.Width/2)-290,this.Top);
        }

        private void login_Load(object sender, EventArgs e)
        {
           set_login();
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                errorProvider1.SetError(txt_username, "Username Required !");
            }
            else if (txt_password.Text == "")
            {
                errorProvider2.SetError(txt_password, "Password Required !");
                errorProvider1.Clear();
            }
            login_access la = new login_access()
            {
                user = txt_username.Text,
                pass = txt_password.Text
            };
            MessageBox.Show(loginAccessManager.login(la));
            main.u = la.user;
            Form form = new main();
            form.Show();
            this.Hide();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_head_Click(object sender, EventArgs e)
        {

        }
        private void cleartext()
        {
            txt_username.Clear();
            txt_password.Clear();
        }
    }
}
