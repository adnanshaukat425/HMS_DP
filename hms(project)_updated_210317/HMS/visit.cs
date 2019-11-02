using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace HMS
{
    class visit
    {
        public string id { get; set; }
        public string pat_id { get; set; }
        public string pat_name { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public string time { get; set; }

        string sql;
        operation op = new operation();

        public DataSet show_visiting_history()
        {
             sql = "SELECT p.name[Patient Name],v.name[Visitor Name],v.date[Date],v.time[Time] FROM patients p ,visiting_history v where p.id=v.patient_id";
             return op.show(sql);
        }

        public void insert_visit(visit v)
        {
             sql = "INSERT INTO visiting_history(patient_id,name,date,time) VALUES (" + v.pat_id + ",'" + v.name + "','" + v.date + "','" + v.time + "')";
             op.insert(sql);
        }

        public DataSet show_patients_combo()
        {
             sql = "SELECT p.id,p.name,p.age,p.gender,p.contact FROM patients p , patients_in pin WHERE p.id=pin.patient_id";
             return op.show(sql);
        }

        public DataSet show_patients(visit v)
        {
             sql = "SELECT p.id,p.name,p.age,p.gender,p.contact FROM patients p WHERE name= '" + v.pat_name + "'";
             return op.show(sql);
        }

         //public void search_visit(DataGridView dgv, TextBox search, ComboBox com_search)
         //{
         //     string q, q1, q2, q3;
         //     q = "SELECT p.name[Patient Name],v.name[Visitor Name],v.date[Date],v.time[Time] FROM patients p ,visiting_history v where p.id=v.patient_id";
         //     q1 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     q2 = q + " AND v.date LIKE '%" + search.Text + "%'";
         //     q3 = q + " AND v.time LIKE '%" + search.Text + "%'";
         //     txt_search(dgv, search, com_search, q, q1, q2, q3);
         //}

    }
}
