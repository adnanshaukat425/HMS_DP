using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HMS
{
    class pat_out:operation
    {
        SqlConnection scon = new SqlConnection(connection.connmethod());
        SqlCommand scom;
        SqlDataReader sdr;
        string sql;

        public void show_pat_details(Label id, Label age, Label gen, Label ph, DateTimePicker dd, TextBox ln, TextBox dis, ComboBox cdn, ComboBox cpn, ToolStripStatusLabel e)
        {
            try
            {
                scon.Open();

                sql = "Select p.id,p.age,p.gender,p.contact,pin.date_of_discharge,pin.lab_id,pin.disease,d.name from patients p JOIN patients_in pin ON p.id = pin.patient_id JOIN Doctors d ON d.id = pin.doctor_id WHERE p.name= '" + cpn.SelectedItem.ToString() + "'";
                scom = new SqlCommand(sql, scon);
                sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    id.Text = sdr[0].ToString();
                    age.Text = sdr[1].ToString();
                    gen.Text = sdr[2].ToString();
                    ph.Text = sdr[3].ToString();
                    dd.Text = sdr[4].ToString();
                    ln.Text = sdr[5].ToString();
                    dis.Text = sdr[6].ToString();
                    cdn.SelectedItem = sdr[7].ToString();
                }
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void show_pat_details2(Label id,Label age,Label gen,Label ph,DateTimePicker dd,TextBox ln,TextBox dis,ComboBox cdn,ComboBox cpn,ToolStripStatusLabel e)
        {
            try
            {
                scon.Open();
                
                sql = "Select p.id,p.age,p.gender,p.contact,pout.date,pout.lab_id,pout.disease,d.name from patients p JOIN patients_out pout ON p.id = pout.patient_id JOIN Doctors d ON d.id = pout.doctor_id WHERE p.name= '" + cpn.SelectedItem.ToString() + "'"; 
                scom = new SqlCommand(sql, scon);
                sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    cdn.SelectedItem = sdr[7].ToString();
                    id.Text = sdr[0].ToString();
                    age.Text = sdr[1].ToString();
                    gen.Text = sdr[2].ToString();
                    ph.Text = sdr[3].ToString();
                    dd.Text = sdr[4].ToString();
                    ln.Text = sdr[5].ToString();
                    dis.Text = sdr[6].ToString();
                    
                }
                scon.Close();
              }
              catch (Exception ex)
              {
                  e.Text = ex.Message;
              }
        }

        public void show_patient_out(DataGridView dsp,ToolStripStatusLabel e)
        {
            try
            {
                scon.Close();
                sql = "Select p.name[Name],d.name[Doctor Name],pout.lab_id[Lab No.],pout.disease[Disease],pout.date[Discharge Date] from patients p, Doctors d ,patients_out pout WHERE p.id = pout.patient_id AND d.id = pout.doctor_id";
                dsp.DataSource = show(sql).Tables[0];
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void show_data(ComboBox cpn, ComboBox cdn, ToolStripStatusLabel e)
        {
            try
            {
                sql = "SELECT p.name FROM patients p, patients_in pin WHERE p.id = pin.patient_id";//pin.id,
                show_combobox(sql, cpn);

                sql = "SELECT name FROM Doctors";
                show_combobox(sql, cdn);
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void cleartext(TextBox ln, TextBox dis, DateTimePicker dd, Label did, Label ddept, Label dgen, Label dph, Label pid, Label page, Label pgen, Label pph)
        {
            ln.Text = "";
            dis.Text = "";
            dd.Text = DateTime.Now.ToString();

            did.Text = "";
            ddept.Text = "";
            dgen.Text = "";
            dph.Text = "";

            pid.Text = "";
            page.Text = "";
            pgen.Text = "";
            pph.Text = "";
        }

        public void insert(ComboBox cpn,Label did, Label ddept, Label dgen, Label dph, Label pid, Label page, Label pgen, Label pph,TextBox ln,TextBox dis,DateTimePicker dd,ToolStripStatusLabel e)
        {
            try
            {
                if (cpn.SelectedIndex == -1)
                {
                    e.Text = "Required All Fields !";
                }
                else if (cpn.SelectedIndex != -1)
                {
                    sql = "INSERT INTO patients_out(patient_id,doctor_id,lab_id,disease,date) VALUES (" + pid.Text.ToString() + "," + did.Text.ToString() + "," + ln.Text.ToString() + ",'" + dis.Text.ToString() + "','" + dd.Text.ToString() + "')";
                    insert(sql);
                    e.Text = "Patient " + cpn.SelectedItem.ToString() + " is Discharged from Hospital!";
                    cleartext(ln, dis,dd,did, ddept, dgen, dph, pid, page, pgen, pph);
                }
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void search_pat_out(DataGridView dgv, TextBox search, ComboBox com_search)
        {
            string q, q1, q2, q3;
            q = "Select p.name[Name],d.name[Doctor Name],pout.lab_id[Lab No.],pout.disease[Disease],pout.date[Discharge Date] from patients p, Doctors d ,patients_out pout WHERE p.id = pout.patient_id AND d.id = pout.doctor_id";
            q1 = q + " AND p.name LIKE '%" + search.Text + "%'";
            q2 = q + " AND d.name LIKE '%" + search.Text + "%'";
            q3 = q + " AND pout.disease LIKE '%" + search.Text + "%'";
            txt_search(dgv, search, com_search, q, q1, q2, q3);
        }

        public void update_pat(ComboBox cpn, Label did, Label ddept, Label dgen, Label dph, Label pid, Label page, Label pgen, Label pph, TextBox ln, TextBox dis, DateTimePicker dd, ToolStripStatusLabel e)
        {
            try
            {
                scon.Close();
                if (cpn.SelectedIndex == -1 )
                {
                    e.Text = "All Fields Required !";
                }
                else
                {
                    sql = "Update patients_out SET patient_id ='" + pid.Text.ToString() + "',doctor_id = '" + did.Text.ToString() + "',lab_id = '" + ln.Text.ToString() + "',disease = '" + dis.Text.ToString() + "',date = '" + dd.Text.ToString() + "' WHERE patient_id ='" + pid.Text.ToString() + "'";
                    //sql = "Update patients_out SET date = '" + dd.Text.ToString() + "' WHERE patient_id ='" + pid.Text.ToString() + "'";
                    insert(sql);
                    e.Text = "Data Updated !";
                    cleartext(ln, dis, dd, did, ddept, dgen, dph, pid, page, pgen, pph);
                }

            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void delete_pat(ComboBox cpn, Label pid, Label did, Label ddept, Label dgen, Label dph, Label page, Label pgen, Label pph,TextBox ln,TextBox dis,DateTimePicker dd ,ToolStripStatusLabel e)
        {
            try
            {
                if (cpn.SelectedIndex == -1)
                {
                    e.Text = "Select Name !";
                }
                else
                {
                    sql = "DELETE FROM patients_out WHERE patient_id ='" + pid.Text.ToString() + "'";
                    insert(sql);
                    e.Text = "Data Deleted !";
                    cleartext(ln, dis, dd, did, ddept, dgen, dph, pid, page, pgen, pph);
                }
            }
            catch //(Exception ex)
            {
                //e.Text = ex.Message;
            }
        }

        public void show_data2(ComboBox cpn,ComboBox cdn, ToolStripStatusLabel e)
        {
            try
            {
                sql = "SELECT p.name FROM patients p, patients_out pout WHERE p.id = pout.patient_id";
                show_combobox(sql, cpn);

                sql = "SELECT d.name FROM Doctors d, patients_in pin WHERE d.id = pin.doctor_id";
                show_combobox(sql, cdn);
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

    }
}
