using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HMS
{
    class operation
    {
        SqlConnection scon = new SqlConnection(connection.connmethod());
        SqlDataAdapter sda;
        SqlCommand scom;
        SqlDataReader sdr;
        DataSet ds;

        string sql;
        string result;

        public DataSet show(string q)
        {
            ds = new DataSet();
            using (SqlConnection scon = new SqlConnection(connection.connmethod()))
            {
                scon.Open();
                sda = new SqlDataAdapter(q, scon);
                sda.Fill(ds);
            }
            return ds;
        }

        public DataSet show_combobox(string q)
        {
            ds = new DataSet();
            using (SqlConnection scon = new SqlConnection(connection.connmethod()))
            {
                scon.Open();
                sda = new SqlDataAdapter(q, scon);
                sda.Fill(ds);
            }
            return ds;
        }

        public void insert(string q)
        {
            scom = new SqlCommand(q, scon);
            scon.Open();
            scom.ExecuteNonQuery();
            scon.Close();
        }

        public void show_doc(Label did, Label ddep, Label dgen, Label dph, ComboBox doc_name, ToolStripStatusLabel e)
        {
            try
            {
                scon.Close();
                scon.Open();
                sql = "Select d.id,dep.name,d.gender,d.contact from Doctors d JOIN Departments dep ON d.department_id = dep.id WHERE d.name= '" + doc_name.SelectedItem.ToString() + "'";
                scom = new SqlCommand(sql, scon);
                sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    did.Text = sdr[0].ToString();
                    ddep.Text = sdr[1].ToString();
                    dgen.Text = sdr[2].ToString();
                    dph.Text = sdr[3].ToString();
                }
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public void show_pat(ComboBox cpn, Label pid, Label page, Label pgen, Label pph, ToolStripStatusLabel e)
        {
            try
            {
                scon.Open();
                sql = "Select p.id,p.age,p.gender,p.contact from patients p where p.name= '" + cpn.SelectedItem.ToString() + "'";//,patients_in pin where p.id= pin.patient_id AND 
                scom = new SqlCommand(sql, scon);
                sdr = scom.ExecuteReader();
                while (sdr.Read())
                {
                    pid.Text = sdr[0].ToString();
                    page.Text = sdr[1].ToString();
                    pgen.Text = sdr[2].ToString();
                    pph.Text = sdr[3].ToString();
                }
                scon.Close();
            }
            catch (Exception ex)
            {
                e.Text = ex.Message;
            }
        }

        public string def_status()
        {
            result = "Ready";
            return result;
        }
        public string ins_status()
        {
            result = "Inserting Data...";
            return result;
        }

        public void txt_search(DataGridView dgv ,TextBox search,ComboBox com_search,string q,string q1,string q2,string q3)
        {
            dgv.DataSource = null;
            if (!search.Text.Equals(""))
            {
                switch (com_search.SelectedIndex)
                {
                    case 0:
                        dgv.DataSource = show(q1).Tables[0];
                        break;
                    case 1:
                        dgv.DataSource = show(q2).Tables[0];
                        break;
                    case 2:
                        dgv.DataSource = show(q3).Tables[0];
                        break;
                    default:
                        dgv.DataSource = show(q).Tables[0];
                        break;
                }
            }
            else
            {
                dgv.DataSource = show(q).Tables[0];
            }    
        }

        public string get_id(string q)
        {
            scon.Open();
            scom = new SqlCommand(q, scon);
            sdr = scom.ExecuteReader();
            while (sdr.Read())
            {
                result = sdr["id"].ToString();
            }
            scon.Close();
            return result;
        }
    }
}
