using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    class pat
    {
        SqlConnection scon = new SqlConnection(connection.connmethod());
        SqlCommand scom;
        SqlDataReader sdr;
        string sql,gender,pat_id;
        operation op = new operation();

        public void show_patients(DataGridView dgv_pat,ToolStripStatusLabel e)
        {
            try
            {
                sql = "select name[Name],age[Age],address[Address],gender[Gender],contact[Contact] from patients";
                dgv_pat.DataSource = op.show(sql).Tables[0];
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        void cleartext(TextBox con,RichTextBox add,TextBox age,RadioButton m,RadioButton f)
        {
            con.Text = "";
            add.Text = "";
            age.Text = "";
            m.Checked = true;
            f.Checked = false;
        }

        public void insert_patient(TextBox name,TextBox con,RichTextBox add,TextBox age,RadioButton m,RadioButton f,ToolStripStatusLabel e)
        {
            try
            {
                if (name.Text == "" || con.Text == "" || add.Text == "" || age.Text == "")
                {
                    e.Text = "All Fields Required !";
                }
                else if (name.Text != "" && con.Text != "" && add.Text != "" && age.Text != "")
                {
                    if (m.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    sql = "INSERT INTO patients(name,age,gender,address,contact) VALUES ('" + name.Text.ToString() + "' , '" + age.Text.ToString() + "' , '" + gender.ToString() + "' , '" + add.Text.ToString() + "' , '" + con.Text.ToString() + "')";
                    op.insert(sql);
                    e.Text = "Patient "+ name.Text.ToString() +" Added to Hospital";
                    cleartext(con,add,age,m,f);
                }

            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void search_pat(DataGridView dgv, TextBox search, ComboBox com_search)
        {
            string q, q1, q2,q3;
            q = "select name[Name],age[Age],address[Address],gender[Gender],contact[Contact] from patients";
            q1 = q + " WHERE name LIKE '%" + search.Text + "%'";
            q2 = q + " WHERE name LIKE '%" + search.Text + "%'";
            q3 = q + " WHERE name LIKE '%" + search.Text + "%'";
            op.txt_search(dgv, search, com_search, q, q1, q2,q3);
        }

        public void show_pat_details(ComboBox com_pat, RichTextBox dadd, TextBox dage, TextBox dph, RadioButton rm, RadioButton rf, ToolStripStatusLabel e)
        {
            try
            {
                scon.Open();
                sql = "SELECT age,address,gender,contact FROM patients WHERE name = '" + com_pat.Text.ToString() +"'";
                scom = new SqlCommand(sql, scon);
                sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    if (sdr[2].ToString() == "Male      ")
                    {
                        rm.Checked = true;
                    }
                    else 
                    {
                        rf.Checked = true;
                    }
                    dadd.Text = sdr[1].ToString();
                    dage.Text = sdr[0].ToString();
                    dph.Text = sdr[3].ToString();
                }
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void update_pat(ComboBox name, TextBox con,TextBox age, RichTextBox add,RadioButton rm, RadioButton rf, ToolStripStatusLabel e)
        {
            try
            {
                if (name.SelectedIndex == -1 || age.Text == "" || con.Text == "" || add.Text == "")//|| dep.SelectedIndex == -1
                {
                    e.Text = "All Fields Required !";
                }
                else if (name.SelectedIndex != -1 && age.Text != ""  && con.Text != "" && add.Text != "")// && dep.SelectedIndex != -1
                {
                    if (rm.Checked)
                    {
                        gender = "Male";
                    }
                    else
                    {
                        gender = "Female";
                    }

                    sql = "SELECT id from patients where name = '" + name.SelectedItem.ToString() + "';";
                    pat_id = op.get_id(sql);

                    sql = "Update patients SET name ='" + name.SelectedItem.ToString() + "',gender = '" + gender + "',age = '" + age.Text.ToString() + "',address = '" + add.Text.ToString() + "',contact = '" + con.Text.ToString() + "' WHERE id ='" + pat_id + "'";
                    op.insert(sql);
                    e.Text = "Data Updated !";
                    cleartext2(con, add, age, rm, rf);
                }

            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void cleartext2(TextBox con,RichTextBox add,TextBox age,RadioButton m,RadioButton f)
        {
            con.Text = "";
            add.Text = "";
            age.Text = "";
            m.Checked = true;
            f.Checked = false;
        }

        public void show_pat_combo(ComboBox cpn, ToolStripStatusLabel e)
        {
            try
            {
                sql = "Select name from patients";
                op.show_combobox(sql, cpn);
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void delete_pat(ComboBox name, ToolStripStatusLabel e,TextBox con,TextBox age, RichTextBox add,RadioButton rm, RadioButton rf)
        {
            try
            {
                if (name.SelectedIndex == -1)
                {
                    e.Text = "Select Name !";
                }
                else
                {
                    sql = "SELECT id from patients where name = '" + name.SelectedItem.ToString() + "';";
                    pat_id = op.get_id(sql);

                    sql = "DELETE FROM patients WHERE id ='" + pat_id + "'";
                    op.insert(sql);
                    e.Text = "Data Deleted !";
                    cleartext2(con, add, age, rm, rf);
                }
            }
            catch //(Exception ex)
            {
                e.Text = "You can't delete patient " + name.SelectedItem.ToString() + " because patient is already admitted to Hospital";
            }
        }
    }
}
