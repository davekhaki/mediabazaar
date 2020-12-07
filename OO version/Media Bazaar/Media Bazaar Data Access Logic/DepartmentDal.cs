using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Data_Access_Logic
{
    public class DepartmentDal
    {
        private string sql;
        private readonly DbHelper dbHelper = new DbHelper();

        public DataTable GetAllDepartments()
        {
            sql = $"SELECT * FROM departments";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                var reader = dbHelper.Cmd.ExecuteReader();
                var dt = new DataTable();
                dt.Load(reader);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving departments:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
            return null;
        }

        public void UpdateDetails(int id, string oldName, string newName)
        {
            sql = $"UPDATE departments SET name = @newName WHERE id = @id AND name = @oldName";
            try
            {
                dbHelper.Conn.Open();
                dbHelper.Cmd = new MySqlCommand(sql, dbHelper.Conn);
                dbHelper.Cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                dbHelper.Cmd.Parameters.Add("@oldName", MySqlDbType.String).Value = oldName;
                dbHelper.Cmd.Parameters.Add("@newName", MySqlDbType.String).Value = newName;
                dbHelper.Cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing department details:" + ex);
            }
            finally
            {
                dbHelper.Conn.Close();
            }
        }

        public void AddDepartment()
        {
            throw new NotImplementedException();
        }

        public void DeleteDepartment()
        {
            // hmm.
        }
    }
}
