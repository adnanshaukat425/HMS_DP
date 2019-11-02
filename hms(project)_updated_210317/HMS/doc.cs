using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace HMS
{
    class doc
    {
        public string doct_id{ get; set; }
        public string doct_name{ get; set; }
        public string gender { get; set; }
        public string depart_id { get; set; }
        public string depart_name { get; set; }
        public string contact { get; set; }
        public string address { get; set; }

        string sql;
        operation op = new operation();

        public DataSet show_doctors()
        {
             sql = "SELECT d.id,d.name[Doctor Name],dep.name[Department],d.gender[Gender],d.address[Address],d.contact[Contact No.] from Doctors d JOIN Departments dep ON d.department_id = dep.id";
             return op.show(sql);
        }

        public DataSet select_dept()
        {
             sql = "SELECT * FROM departments";
             return op.show(sql);
        }

        public DataSet show_doc_combo()
        {
             sql = "Select id,name from Doctors";
             return op.show(sql);
        }

        public DataSet show_dept_combo()
        {
             sql = "Select id,name from Departments";
             return op.show(sql);
        }

        public string insert_doc(doc d)
        {
             sql = "SELECT id from Departments where name = '" + d.depart_name + "';";
             d.depart_id = op.get_id(sql);

             sql = "insert into doctors(name,department_id,gender,address,contact) values ('" + d.doct_name + "' , '" + d.depart_id + "' , '" + d.gender + "' , '" + d.address + "' , '" + d.contact + "')";
             op.insert(sql);
             return d.doct_name;
        }

        //public void search_doc(datagridview dgv, textbox search, combobox com_search)
        //{
        //     string q, q1, q2, q3;
        //     q = "select d.name[doctor name],dep.name[department],d.gender[gender],d.address[address],d.contact[contact no.] from doctors d join departments dep on d.department_id = dep.id";
        //     q1 = q + " where d.name like '%" + search.text + "%'";
        //     q2 = q + " where dep.name like '%" + search.text + "%'";
        //     q3 = q + " where d.name like '%" + search.text + "%'";
        //     txt_search(dgv, search, com_search, q, q1, q2, q3);
        //}

        public DataSet show_doc_details(doc d)
        {
             sql = "Select dep.name,d.gender,d.address,d.contact from Doctors d JOIN Departments dep ON d.department_id = dep.id WHERE d.name= '" + d.doct_name + "'";
             return op.show(sql);
        }

        public void update_doc(doc d)
        {
             sql = "SELECT id from Doctors where name = '" + d.doct_name + "';";
             d.doct_id = op.get_id(sql);

             sql = "SELECT id from Departments where name = '" + d.depart_name + "';";
             d.depart_id = op.get_id(sql);

             sql = "Update Doctors SET name ='" + d.doct_name + "',department_id = '" + d.depart_id + "',gender = '" + d.gender + "',address = '" + d.address + "',contact = '" + d.contact + "' WHERE id ='" + d.doct_id + "'";
             op.insert(sql);
        }

        public void delete_doc(doc d)
        {
             sql = "SELECT id from Doctors where name = '" + d.doct_name + "';";
             string doc_id = op.get_id(sql);

             sql = "DELETE FROM Doctors WHERE id ='" + d.doct_id + "'";
             op.insert(sql);
        }
    }   
}
