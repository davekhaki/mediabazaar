using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ArtichokeData
{
    public class DepartmentManager
    {
        // all the department related data access
        List<string> departmentNames = new List<string>();
        MySqlConnection conn = new MySqlConnection(Config.conString);

        public void GetAllDepartments(DataGridView dataGrid)
        {           
            string sql = "SELECT * FROM departments";
            try
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(sql, conn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
                DataTable dbaTableset = new DataTable();
                sda.Fill(dbaTableset);

                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbaTableset;
                dataGrid.DataSource = bSource;

                sda.Update(dbaTableset);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public List<string> GetAllDepartmentNames()
        {
            string sql = "SELECT DeptName FROM departments";
            MySqlCommand command = new MySqlCommand(sql, conn);
            MySqlDataReader reader = null;

            try
            {
                conn.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    departmentNames.Add(reader.GetString("DeptName"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return departmentNames;
        }
    }
}
