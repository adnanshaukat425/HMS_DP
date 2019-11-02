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
    public partial class doctors : Form
    {
        doc d= new doc();
        operation op = new operation();
        SqlConnection scon = new SqlConnection(connection.connmethod());
        DataSet ds;
        DataTable dt;

        public doctors()
        {
            InitializeComponent();


        }

        void set_form()
        {
            this.Top = Screen.PrimaryScreen.WorkingArea.Top + 90;
            this.Location = new Point(15,this.Top);
            this.Font = new Font("Microsoft Sans Serif",9);
        }

        private void doctor_Load(object sender, EventArgs e)
        {
            set_form();
            
            try
            {
                 scon.Open();

                 view_doctors();
                 listbox_departments();
                 combobox_doctors();
                 combobox_departments();

                 scon.Close();
            }
            catch (Exception ex)
            {
                 statusStrip1.Text =  ex.Message;
            }

            dgv_doc.Columns[0].Visible = false; 
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form depart = new department();
            depart.FormClosed += new FormClosedEventHandler(dept_closed);
            depart.StartPosition = FormStartPosition.CenterScreen;
            depart.Show();
        }

        private void dept_closed(object sender, EventArgs e)
        {
             listbox_departments();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            d.doct_name = txt_name.Text;
            d.depart_name = lb_department.SelectedItem.ToString();
            d.contact = txt_con.Text;
            d.address = txt_add.Text;
            try
            {

                if (d.doct_name == "" || d.contact == "" || d.address == "" || lb_department.SelectedIndex == -1)
                {
                    lbl_status.Text = "All Fields Required !";
                }
                else if (d.doct_name != "" && d.contact != "" && d.address != "" && lb_department.SelectedIndex != -1)
                {
                    if (rad_male.Checked)
                    {
                        d.gender = "Male";
                    }
                    else
                    {
                        d.gender = "Female";
                    }

                    lbl_status.Text = d.insert_doc(d) + " is hired to hospital";
                    cleartext();
                }
            }
            catch (Exception ex)
            {
                lbl_status.Text = ex.Message;
            }

            view_doctors();
            combobox_doctors();
            combobox_departments();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
             lbl_status.Text = op.def_status();
        }

        private void btn_close_window_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //obj_doc.search_doc(dgv_doc, txt_search, com_search);
        }

        private void txt_name_com_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
             {
                  ds = d.show_doc_details(d);
                  dt = new DataTable();
                  dt = ds.Tables[0];
                  foreach (DataRow dr in dt.Rows)
                  {
                       if (dr[1].ToString() == "Male      ")
                       {
                            rad_male2.Checked = true;
                       }
                       else
                       {
                            rad_female2.Checked = true;
                       }
                       com_dep.SelectedItem = dr[0].ToString();
                       txt_add2.Text = dr[2].ToString();
                       txt_con2.Text = dr[3].ToString();
                  }
             }
             catch (Exception ex)
             {
                  lbl_status.Text = ex.Message;
             }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
             try
               {
                    if (txt_name_com.SelectedIndex == -1 || txt_con2.Text == "" || txt_add2.Text == "")//|| dep.SelectedIndex == -1
                    {
                         lbl_status.Text = "All Fields Required !";
                    }
                    else if (txt_name_com.SelectedIndex != -1 && txt_con2.Text != "" && txt_add2.Text != "")// && dep.SelectedIndex != -1
                    {
                         if (rad_male2.Checked)
                         {
                              d.gender = "Male";
                         }
                         else
                         {
                              d.gender = "Female";
                         }

                         d.contact = txt_con2.Text;
                         d.address = txt_add2.Text;

                         d.update_doc(d);

                         lbl_status.Text = "Data Updated !";
                         cleartext();
                    }

               }
               catch (Exception ex)
               {
                    lbl_status.Text = ex.Message;
               }

             view_doctors();
             combobox_doctors();
             combobox_departments();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
             try
               {
                    if (txt_name_com.SelectedIndex == -1)
                    {
                         lbl_status.Text = "Select Name !";
                    }
                    else
                    {
                         d.delete_doc(d);
                         lbl_status.Text = "Data Deleted !";
                         cleartext();
                    }
               }
             catch (Exception ex)
             {
                  lbl_status.Text = ex.Message;
             }

             view_doctors();
             combobox_doctors();
             combobox_departments();
        }

        private void cleartext()
        {
             txt_add.Text = "";
             txt_con.Text = "";
             txt_name.Text = "Dr.";
             rad_male.Checked = true;
             rad_female.Checked = false;
        }

        private void view_doctors() 
        {
             ds = d.show_doctors();
             dgv_doc.DataSource = ds.Tables[0];
        }

        public void listbox_departments()
        {
             lb_department.Items.Clear();
             ds = d.select_dept();
             dt = new DataTable();
             dt = ds.Tables[0];
             foreach (DataRow dr in dt.Rows)
             {
                  lb_department.Items.Add(dr[1].ToString());
             }
             lb_department.DisplayMember = "name";
             lb_department.ValueMember = "id";
        }

        private void combobox_doctors()
        {
             ds = d.show_doc_combo();
             dt = new DataTable();
             dt = ds.Tables[0];
             foreach (DataRow dr in dt.Rows)
             {
                  txt_name_com.Items.Add(dr[1].ToString());
                  txt_name_com.DisplayMember = "name";
                  txt_name_com.ValueMember = "id";
                  
             }
        }

        private void combobox_departments()
        {
             ds = d.show_dept_combo();
             dt = new DataTable();
             dt = ds.Tables[0];
             foreach (DataRow dr in dt.Rows)
             {
                  com_dep.Items.Add(dr[1].ToString());
             }
        }

        private void com_dep_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
