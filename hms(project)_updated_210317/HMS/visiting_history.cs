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
    public partial class visiting_history : Form
    {
        visit v = new visit();
        operation op = new operation();

        DataSet ds;
        DataTable dt;

        public visiting_history()
        {
            InitializeComponent();

            v.pat_id = p_lbl_selected_id.Text;
            v.pat_name = cb_patient_name.SelectedItem.ToString();
            v.name = txt_name.Text;
            v.date = dtp_date.Text;
            v.time = dtp_time.Text;
        }

        void set_form()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 90;
            this.Location = new Point(15, this.Top);
            this.Font = new Font("Microsoft Sans Serif", 9);
        }

        private void visiting_history_Load(object sender, EventArgs e)
        {
            set_form();
            try
            {
                 combobox_patients();
                 view_visitinghistory();
            }
            catch (Exception ex)
            {
                 lbl_status.Text = ex.Message;
            }
        }

        private void btn_insert_save_Click(object sender, EventArgs e)
        {
             try
               {
                    if (cb_patient_name.SelectedIndex == -1 || txt_name.Text == "")
                    {
                         lbl_status.Text = "Required All Fields !";
                    }
                    else
                    {
                         v.insert_visit(v);
                         lbl_status.Text = txt_name.Text.ToString() + " visited to patient " + cb_patient_name.SelectedItem.ToString();
                         cleartext();
                    }
               }
             catch (Exception ex)
             {
                  lbl_status.Text = ex.Message;
             }
             combobox_patients();
             view_visitinghistory();
        }

        private void cb_patient_name_SelectedIndexChanged(object sender, EventArgs e)
        {
             patients_details();
        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
             lbl_status.Text = op.def_status();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //visit_obj.search_visit(dgv_visiting_history, txt_search,com_search);
        }

        private void view_visitinghistory()
        {
             ds = v.show_visiting_history();
             dgv_visiting_history.DataSource = ds.Tables[0];
        }

        private void combobox_patients()
        {
             ds = v.show_patients_combo();
             dt = new DataTable();
             dt = ds.Tables[0];
             foreach (DataRow dr in dt.Rows)
             {
                  cb_patient_name.Items.Add(dr[1].ToString());
             }
        }

        private void patients_details()
        {
             ds = v.show_patients(v);
             dt = new DataTable();
             dt = ds.Tables[0];
             foreach (DataRow dr in dt.Rows)
             {
                  p_lbl_selected_id.Text = dr[0].ToString();
                  p_lbl_selected_age.Text = dr[2].ToString();
                  p_lbl_selected_gender.Text = dr[3].ToString();
                  p_lbl_selected_phone.Text = dr[4].ToString();
             }
        }

        private void cleartext()
        {
             cb_patient_name.SelectedText = "";
             txt_name.Text = "";

             p_lbl_selected_id.Text = "";
             p_lbl_selected_age.Text = "";
             p_lbl_selected_gender.Text = "";
             p_lbl_selected_phone.Text = "";
        }
    }
}
