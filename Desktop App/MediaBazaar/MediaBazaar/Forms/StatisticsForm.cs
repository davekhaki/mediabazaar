using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaar.Logic;
using MediaBazaarOO.Forms;

namespace MediaBazaar.Forms
{
    public partial class StatisticsForm : Form
    {
        private readonly StatisticsManager sm = new StatisticsManager();
        private string username;
        public StatisticsForm(string username)
        {
            InitializeComponent();
            this.username = username;

            Text = "Admin | Statistics | " + username;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new AdminForm(username);
            form.Show();
            this.Hide();
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            // Gender Chart
            chart1.Titles.Add("Gender Distribution");
            chart1.Series["Gender"].IsValueShownAsLabel = true;
            this.chart1.Series["Gender"].Points.AddXY("Male", sm.GetNrPerGender("Male"));
            this.chart1.Series["Gender"].Points.AddXY("Female", sm.GetNrPerGender("Female"));

            // Department Chart
            this.chart2.Titles.Add("Employee/Department Distribution");
            chart2.Series["DepartmentName"].IsValueShownAsLabel = true;
            this.chart2.Series["DepartmentName"].Points.AddXY("Finance", sm.GetNrPerDepartment("Finance"));

            // Role Chart
            this.chart3.Titles.Add("Role Distribution");
            chart3.Series["Role"].IsValueShownAsLabel = true;
            this.chart3.Series["Role"].Points.AddXY("Admin", sm.GetNrPerRole("Admin"));
            this.chart3.Series["Role"].Points.AddXY("Manager", sm.GetNrPerRole("Manager"));
            this.chart3.Series["Role"].Points.AddXY("Employee", sm.GetNrPerRole("Employee"));

            // Salary Chart
            this.chart4.Titles.Add("Average Salary Distribution");
            chart4.Series["Salary"].IsValueShownAsLabel = true;
            this.chart4.Series["Salary"].Points.AddXY("Average Salary", sm.GetAverageSalary());

            // Person Chart
            this.chart5.Titles.Add("Employee Count");
            chart5.Series["Total"].IsValueShownAsLabel = true;
            this.chart5.Series["Total"].Points.AddXY("Average Salary", sm.GetTotalEmployees());
        }
    }
}
