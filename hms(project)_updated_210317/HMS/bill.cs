using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace HMS
{
    class bill 
    {
        public string pat_id { get; set; }
        public string pat_name { get; set; }
        public string lab_charges { get; set; }
        public string doc_charges { get; set; }
        public string med_charges { get; set; }
        public string room_charges { get; set; }
        public string op_charges { get; set; }
        public string nur_charges { get; set; }
        public string nod { get; set; }
        public string advance { get; set; }
        public int _bill { get; set; }

        string sql;

        SqlConnection scon = new SqlConnection(connection.connmethod());
        SqlCommand scom;
        SqlDataReader sdr;
        operation op = new operation();

        public DataSet show_bill_in()
        {
             sql = "SELECT p.name[Name],b.lab_charges[Lab Charges],b.doctor_charges[Doctor Charges],b.medicine_charges[Medicine Charges],b.room_charges[Room Charges],b.operation_charges[Operation Charges],b.nursing_charges[Nursing Charges],b.num_of_days[Days],b.advance[Advance],b.bill[Bill] FROM patients p ,patients_in_bill b WHERE p.id = b.patient_id";
             return op.show(sql);
        }

        public DataSet show_bill_out()
        {
             sql = "SELECT p.name[Name],b.lab_charges[Lab Charges],b.doctor_charges[Doctor Charges],b.medicine_charges[Medicine Charges],b.nursing_charges[Nursing Charges],b.bill[Bill] FROM patients p ,patients_out_bill b WHERE p.id = b.patient_id";
             return op.show(sql);
        }

        public DataSet show_patients_in()
        {
             sql = "SELECT p.name FROM patients p JOIN patients_in pin ON p.id = pin.patient_id";
             return op.show(sql);
        }

        public DataSet show_patients_combo()
        {
             sql = "SELECT p.name FROM patients p  WHERE NOT EXISTS (SELECT pin.id FROM patients_in pin where p.id = pin.patient_id)";
             return op.show(sql);
        }

        public DataSet show_patients(bill b)
        {
             sql = "SELECT p.id,p.name,p.age,p.gender,p.contact FROM patients p WHERE name= '" + b.pat_name + "'";
             return op.show(sql);
        }

        public int bill_in(bill b)
        {
             int cal = Convert.ToInt32(b.med_charges) + Convert.ToInt32(b.room_charges) + Convert.ToInt32(b.nur_charges);
             cal *= Convert.ToInt32(b.nod);
             cal += Convert.ToInt32(b.lab_charges) + Convert.ToInt32(b.doc_charges) + Convert.ToInt32(b.op_charges);
             b._bill = (Convert.ToInt32(cal) - Convert.ToInt32(b.advance));
             return b._bill;
        }

        public int bill_out(bill b)
        {
              b._bill = (Convert.ToInt32(b.doc_charges) + Convert.ToInt32(b.med_charges) + Convert.ToInt32(b.nur_charges));
              return b._bill;
        }

        public DataSet get_advance(bill b)
        {
             sql = "select r.type,pin.lab_id,pin.advance from patients_in pin JOIN Beds b ON pin.bed_id = b.id JOIN rooms r ON r.id = b.room_id JOIN patients p ON p.id = pin.patient_id where p.name = '" + b.pat_name + "'";
             return op.show(sql);
        }

        public void insert_bill_in(bill b)
        {
             sql = "INSERT INTO patients_in_bill(patient_id,lab_charges,doctor_charges,medicine_charges,room_charges,operation_charges,nursing_charges,num_of_days,advance,bill ) VALUES (" + b.pat_id + ",'" + b.lab_charges +"','" + b.doc_charges + "','" + b.med_charges + "','" + b.room_charges + "','" + b.op_charges + "','" + b.nur_charges + "','" + b.nod + "','" + b.advance + "','" + b._bill + "')";
             op.insert(sql);
        }

        public void insert_bill_out(bill b)
        {
             sql = "INSERT INTO patients_out_bill(patient_id,lab_charges,doctor_charges,medicine_charges,nursing_charges,bill ) VALUES (" + b.pat_id + ",'" + b.lab_charges + "','" + b.doc_charges + "','" + b.med_charges + "','" + b.nur_charges + "','" + b._bill + "')";
             op.insert(sql);
        }

         //public void search_bill_in(DataGridView dgv, TextBox search, ComboBox com_search)
         //{
         //     string q, q1, q2, q3;
         //     q = "SELECT p.name[Name],b.lab_charges[Lab Charges],b.doctor_charges[Doctor Charges],b.medicine_charges[Medicine Charges],b.room_charges[Room Charges],b.operation_charges[Operation Charges],b.nursing_charges[Nursing Charges],b.num_of_days[Days],b.advance[Advance],b.bill[Bill] FROM patients p ,patients_in_bill b WHERE p.id = b.patient_id";
         //     q1 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     q2 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     q3 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     txt_search(dgv, search, com_search, q, q1, q2, q3);
         //}

         //public void search_bill_out(DataGridView dgv, TextBox search, ComboBox com_search)
         //{
         //     string q, q1, q2, q3;
         //     q = "SELECT p.name[Name],b.lab_charges[Lab Charges],b.doctor_charges[Doctor Charges],b.medicine_charges[Medicine Charges],b.nursing_charges[Nursing Charges],b.bill[Bill] FROM patients p ,patients_out_bill b WHERE p.id = b.patient_id";
         //     q1 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     q2 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     q3 = q + " AND p.name LIKE '%" + search.Text + "%'";
         //     txt_search(dgv, search, com_search, q, q1, q2, q3);
         //}
    }
}
