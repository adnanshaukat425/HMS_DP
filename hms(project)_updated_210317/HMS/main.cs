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
    public partial class main : Form
    {
        public static string u = null;
        Form login_obj;
        main_form ex_obj = new main_form();
        public main()
        {
            InitializeComponent();
        }

        void set_main()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Top;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }

        //private void login_close(object sender, EventArgs e)
        void login_close()
        {
            lbl_username.Text = u;
            lbl_time.Text = DateTime.Now.ToString();
            menuStrip1.Enabled = true;

            if (lbl_username.Text.ToLower() == "admin")
            {
                newUserToolStripMenuItem.Enabled = true;
            }
            else
            {
                newUserToolStripMenuItem.Enabled = false;
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            set_main();
            login_close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            Form login = new login();
            login.MdiParent = this;
            login.Show();
            this.Hide();
        }

        private void btn_new_user_Click(object sender, EventArgs e)
        {
            Form signup = new signup();
            signup.Show();
        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            Form doc = new doctors();
            doc.Show();
        }

        private void doctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form doc = new doctors();
            doc.MdiParent = this;
            ex_obj.single_form_open();
            doc.Show();
        }

        private void patientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pat = new patients();
            pat.MdiParent = this;
            ex_obj.single_form_open();
            pat.Show();

        }

        private void patientsInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pat_in = new patients_in();
            pat_in.MdiParent = this;
            ex_obj.single_form_open();
            pat_in.Show();

        }

        private void patientsOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pat_out = new patients_out();
            pat_out.MdiParent = this;
            ex_obj.single_form_open();
            pat_out.Show();

        }

        private void roomsAndBedsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form rb = new rooms_beds();
            rb.MdiParent = this;
            ex_obj.single_form_open();
            rb.Show();

        }

        private void labReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form labr = new lab_reports();
            labr.MdiParent = this;
            ex_obj.single_form_open();
            labr.Show();

        }

        private void visitingHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form visith = new visiting_history();
            visith.MdiParent = this;
            ex_obj.single_form_open();
            visith.Show();

        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form bills = new bills();
            bills.MdiParent = this;
            ex_obj.single_form_open();
            bills.Show();

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form signup = new signup();
            signup.MdiParent = this;
            ex_obj.single_form_open();
            signup.Show();

        }

        private void aboutUsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Designed and Developed by\nMuhammed Reza\nShahzaib Rafiq\nFaiq Ahmed");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login_obj = new login();
            this.Hide();
            login_obj.Show();
        }

        void cleartext()
        {
            lbl_username.Text = "";
            lbl_time.Text = "";

        }

        private void lbl_time_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void patientsToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {
            patientsToolStripMenuItem.DropDown.Show(menuStrip1, new Point(0,this.Height));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOTE:\nDelete only works when you Added by Mistake !");
        }
    }
}
