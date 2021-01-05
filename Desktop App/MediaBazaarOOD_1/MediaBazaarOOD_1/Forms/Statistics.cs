using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarOOD_1.LogicLayer;

namespace MediaBazaarOOD_1.Forms
{
    public partial class Statistics : Form
    {
        StatisticsManager sm = new StatisticsManager();
        public Statistics()
        {
            InitializeComponent();
            AutoLoadRoleChart();
            AutoLoadSalaryChart();
            AutoLoadPersonsCountChart();
            AutoLoadGenderChart();
            AutoLoadDepartmentChart();
        }
        public void AutoLoadGenderChart()
        {
            this.chart1.Titles.Add("Gender Distribution");
            chart1.Series["Gender"].IsValueShownAsLabel = true;
            this.chart1.Series["Gender"].Points.AddXY("Male", sm.GetNrPerGender("Male"));
            this.chart1.Series["Gender"].Points.AddXY("Female", sm.GetNrPerGender("Female"));

        }
        public void AutoLoadDepartmentChart()
        {
            this.chart2.Titles.Add("Employee/Department Distribution");
            chart2.Series["DepartmentName"].IsValueShownAsLabel = true;
            this.chart2.Series["DepartmentName"].Points.AddXY("Finance", sm.GetNrPerDepartment("Finance"));
            // this.chart1.Series["Gender"].Points.AddXY("Female", sm.GetNrPerGender("Female"));

        }
        public void AutoLoadRoleChart()
        {
            this.chart3.Titles.Add("Role Distribution");
            chart3.Series["Role"].IsValueShownAsLabel = true;
            this.chart3.Series["Role"].Points.AddXY("Admin", sm.GetNrPerRole("Admin"));
            this.chart3.Series["Role"].Points.AddXY("Manager", sm.GetNrPerRole("Manager"));
            this.chart3.Series["Role"].Points.AddXY("Employee", sm.GetNrPerRole("Employee"));

        }
        public void AutoLoadSalaryChart()
        {
            this.chart4.Titles.Add("Average Salary Distribution");
            chart4.Series["Salary"].IsValueShownAsLabel = true;
            this.chart4.Series["Salary"].Points.AddXY("Average Salary", sm.GetAverageSalary());

        }
        public void AutoLoadPersonsCountChart()
        {
            this.chart5.Titles.Add("Employee Count");
            chart5.Series["Total"].IsValueShownAsLabel = true;
            this.chart5.Series["Total"].Points.AddXY("Average Salary", sm.GetTotalEmployees());

        }

        private void chart5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
