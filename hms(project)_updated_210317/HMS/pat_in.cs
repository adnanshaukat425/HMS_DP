using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMS
{
    class pat_in:operation
    {
        SqlConnection scon = new SqlConnection(connection.connmethod());
        SqlCommand scom;
        SqlDataReader sdr;
        string sql;

        public void show_data(ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn,ToolStripStatusLabel e)
        {
            try
            {
                sql = "Select name from patients";
                show_combobox(sql, cpn);

                sql = "Select id from Beds";
                show_combobox(sql, cbi);

                sql = "Select room_no from rooms";
                show_combobox(sql, crn);

                sql = "Select name from Doctors";
                show_combobox(sql, cdn);
                cdn.DisplayMember = "name";
                cdn.ValueMember = "id";
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void show_data2(ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn, ToolStripStatusLabel e)
        {
            try
            {
                sql = "Select p.name from patients_in pin JOIN patients p ON pin.patient_id = p.id";
                show_combobox(sql, cpn);

                sql = "Select id from Beds";
                show_combobox(sql, cbi);

                sql = "Select room_no from rooms";
                show_combobox(sql, crn);

                sql = "Select name from Doctors";
                show_combobox(sql, cdn);
                cdn.DisplayMember = "name";
                cdn.ValueMember = "id";
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void show_patient_in(DataGridView dsp,ToolStripStatusLabel e)
        {
            try
            {
                sql = "Select p.name[Name],d.name[Doctor Name],pin.lab_id[Lab No.],r.room_no[Room No.],pin.advance[Advance],pin.disease[Disease],pin.date_of_admit[Admit Date],pin.date_of_discharge[Discharge Date],pin.bed_id[Bed No.] from patients p JOIN patients_in pin ON p.id = pin.patient_id JOIN rooms r ON r.id = pin.room_id JOIN Doctors d ON d.id = pin.doctor_id";
                dsp.DataSource = show(sql).Tables[0];
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void show_beds(ComboBox crn,ComboBox cbi,ToolStripStatusLabel e)
        {
            try
            {
                sql = "Select b.id from Beds b JOIN rooms r ON b.room_id = r.id WHERE r.room_no = '" + crn.SelectedItem.ToString() + "'";
                show_combobox(sql, cbi);
            }
            catch (Exception ex)
            {
                e.Text = ex.Message ;
            }
        }

        public void insert_in(ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn, TextBox dis, TextBox ad, TextBox ln, ToolStripStatusLabel e, Label pid, Label page, Label pgen, Label pph, Label did, Label ddept, Label dgen, Label dph, DateTimePicker da, DateTimePicker dd) //string pid,string did,string ln,string crn,string ad,string dis,string da,string dd,string cbi//, Label ddep, Label dgen, Label dph, Label page, Label pgen, Label pph
        {   
            try
            {
                if (cpn.SelectedIndex == -1 || cbi.SelectedIndex == -1 || crn.SelectedIndex == -1 || cdn.SelectedIndex == -1 || dis.Text == "" || ad.Text == "" || ln.Text == "")
                {
                    e.Text = "All Fields Required !";
                }
                else if (cpn.SelectedIndex != -1 && cbi.SelectedIndex != -1 && crn.SelectedIndex != -1 && cdn.SelectedIndex != -1 && dis.Text != "" && ad.Text != "" && ln.Text != "")
                {
                    sql = "INSERT INTO patients_in(patient_id,doctor_id,lab_id,room_id,advance,disease,date_of_admit,date_of_discharge,bed_id) VALUES (" + pid.Text.ToString() + " , " + did.Text.ToString() + " , '" + ln.Text.ToString() + "' ,(SELECT id from rooms where room_no = '" + crn.SelectedItem.ToString() + "'), '" + ad.Text.ToString() + "' , '" + dis.Text.ToString() + "' , '" + da.Text.ToString() + "' , '" + dd.Text.ToString() + "' , '" + cbi.SelectedItem.ToString() + "')";
                    insert(sql);
                    e.Text = "Patient "+cpn.SelectedItem.ToString()+" admitted to Hospital!";
                    cleartext(ln, dis, ad, da, dd, pid, page, pgen, pph, did, ddept, dgen, dph);
                }
            }
            catch(Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void search_pat_in(DataGridView dgv, TextBox search, ComboBox com_search)
        {
            string q, q1, q2,q3;
            q = "Select p.name[Name],d.name[Doctor Name],pin.lab_id[Lab No.],r.room_no[Room No.],pin.advance[Advance],pin.disease[Disease],pin.date_of_admit[Admit Date],pin.date_of_discharge[Discharge Date],pin.bed_id[Bed No.] from patients p JOIN patients_in pin ON p.id = pin.patient_id JOIN rooms r ON r.id = pin.room_id JOIN Doctors d ON d.id = pin.doctor_id";
            q1 = q + " WHERE p.name LIKE '%" + search.Text + "%'";
            q2 = q + " WHERE d.name LIKE '%" + search.Text + "%'";
            q3 = q + " WHERE pin.disease LIKE '%" + search.Text + "%'";
            txt_search(dgv, search, com_search, q, q1, q2,q3);
        }

        public void show_patin_details(ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn, TextBox dis, TextBox ad, TextBox ln, ToolStripStatusLabel e, Label pid, Label did, DateTimePicker da, DateTimePicker dd)
        {
            try
            {
                scon.Open();
                sql = "SELECT d.name,pin.lab_id,r.room_no,pin.advance,pin.disease,pin.date_of_admit,pin.date_of_discharge,pin.bed_id FROM patients p JOIN patients_in pin ON p.id = pin.patient_id JOIN rooms r ON r.id = pin.room_id JOIN Doctors d ON d.id = pin.doctor_id WHERE p.name ='"+cpn.Text.ToString()+"'";
                scom = new SqlCommand(sql, scon);
                sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    cdn.SelectedItem = sdr[0].ToString();
                    ln.Text = sdr[1].ToString();
                    crn.SelectedItem = sdr[2].ToString();
                    ad.Text = sdr[3].ToString();
                    dis.Text = sdr[4].ToString();
                    da.Text = sdr[5].ToString();
                    dd.Text = sdr[6].ToString();
                    cbi.SelectedItem = sdr[7].ToString();
                }
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void update_pat(ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn, TextBox dis, TextBox ad, TextBox ln, ToolStripStatusLabel e, Label pid, Label page, Label pgen, Label pph, Label did, Label ddept, Label dgen, Label dph, DateTimePicker da, DateTimePicker dd)//ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn, TextBox dis, TextBox ad, TextBox ln, ToolStripStatusLabel e, Label pid, Label did, DateTimePicker da, DateTimePicker dd)
        {
            try
            {
                if (cpn.SelectedIndex == -1 || cbi.SelectedIndex == -1 || crn.SelectedIndex == -1 || cdn.SelectedIndex == -1 || dis.Text == "" || ad.Text == "" || ln.Text == "")
                {
                    e.Text = "All Fields Required !";
                }
                else 
                {
                    sql = "Update patients_in SET patient_id ='" + pid.Text.ToString() + "',doctor_id = '" + did.Text.ToString() + "',lab_id = '" + ln.Text.ToString() + "',room_id = (SELECT id from rooms where room_no = '" + crn.SelectedItem.ToString() + "'),advance = '" + ad.Text.ToString() + "',disease = '" + dis.Text.ToString() + "',date_of_admit = '" + da.Text.ToString() + "',date_of_discharge= '" + dd.Text.ToString() + "',bed_id= '" + cbi.Text.ToString() + "' WHERE patient_id ='" + pid.Text.ToString() +"'";
                    insert(sql);
                    e.Text = "Data Updated !";
                    cleartext(ln, dis, ad, da, dd, pid, page, pgen, pph, did, ddept, dgen, dph);
                }

            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void delete_pat(ComboBox cpn, ComboBox cbi, ComboBox crn, ComboBox cdn, TextBox dis, TextBox ad, TextBox ln, ToolStripStatusLabel e, Label pid, Label page, Label pgen, Label pph, Label did, Label ddept, Label dgen, Label dph, DateTimePicker da, DateTimePicker dd)//ComboBox cpn,Label pid, ToolStripStatusLabel e)
        {
            try
            {
                if (cpn.SelectedIndex == -1)
                {
                    e.Text = "Select Name !";
                }
                else
                {
                    sql = "DELETE FROM patients_in WHERE patient_id ='" + pid.Text.ToString() + "'";
                    insert(sql);
                    e.Text = "Data Deleted !";
                    cleartext(ln, dis, ad, da, dd, pid, page, pgen, pph, did, ddept, dgen, dph);
                }
            }
            catch //(Exception ex)
            {
                //e.Text = ex.Message;
            }
        }

        public void cleartext(TextBox ln, TextBox dis, TextBox ad, DateTimePicker da, DateTimePicker dd, Label pid, Label page, Label pgen, Label pph,Label did, Label ddept, Label dgen, Label dph)
        {

            ln.Text = "";
            dis.Text = "";
            ad.Text = "";
            da.Text = DateTime.Now.ToString();
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
    }
}
