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
    public partial class lab_reports : Form
    {
        lab lab_obj = new lab();
        operation op = new operation();

        public lab_reports()
        {
            InitializeComponent();
        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_insert_save_Click(object sender, EventArgs e)
        {
            lab_obj.insert_lab(cb_patient_name, txt_category, dtp_date, dtp_time, p_lbl_selected_id,p_lbl_selected_age,p_lbl_selected_gender,p_lbl_selected_phone,d_lbl_selected_id,d_lbl_selected_dept,d_lbl_selected_gender,d_lbl_selected_phone ,lbl_status);

            lab_obj.show_patients(cb_patient_name, txt_doc, lbl_status);
            lab_obj.show_lab_reports(dgv_lab_reports, lbl_status);
        }

        void set_form()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 90;
            this.Location = new Point(15, this.Top);
            this.Font = new Font("Microsoft Sans Serif", 9);
        }

        private void lab_reports_Load(object sender, EventArgs e)
        {
            set_form();
            lab_obj.show_patients(cb_patient_name, txt_doc, lbl_status);
            lab_obj.show_lab_reports(dgv_lab_reports, lbl_status);
        }

        private void cb_patient_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab_obj.show_pat(cb_patient_name, p_lbl_selected_id, p_lbl_selected_age, p_lbl_selected_gender, p_lbl_selected_phone, lbl_status);
        }

        private void txt_doc_TextChanged(object sender, EventArgs e)
        {
            lab_obj.show_doc(d_lbl_selected_id, d_lbl_selected_dept, d_lbl_selected_gender, d_lbl_selected_phone, cb_patient_name, lbl_status);
        }

        private void tab_control_SelectedIndexChanged(object sender, EventArgs e)
        {
             lbl_status.Text = op.def_status();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            lab_obj.search_lab(dgv_lab_reports, txt_search, com_search);
        }

        private void txt_doc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lab_obj.show_doc(d_lbl_selected_id, d_lbl_selected_dept, d_lbl_selected_gender, d_lbl_selected_phone,txt_doc, lbl_status);
        }
    }
}
