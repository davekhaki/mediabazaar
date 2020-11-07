using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ArtichokeData
{
    public class EmployeeManager
    {
        //all the employee related data access

        public void GetAllEmployees(DataGridView dataGrid)
        {
            MySqlConnection conn = new MySqlConnection(Config.conString);
            string sql = "SELECT * FROM employee";
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

        public void AddNewEmployee()
        {

        }
    }
}
