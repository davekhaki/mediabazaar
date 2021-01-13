using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MediaBazaar.Data;
using MediaBazaar.Entities;

namespace MediaBazaar.Logic
{
    public class DepartmentManager
    {
        private List<Department> departments;

        public DepartmentManager()
        {
            departments = DepartmentData.GetAllDepartments();
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }

        public void AddNewDepartment(Department department)
        {
            try
            {
                if (departments.Contains(department)) return;
                DepartmentData.AddDepartment(department);
                departments.Add(department);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }

        }

        public void EditDepartment(Department department)
        {
            foreach (var dep in departments)
            {
                if (dep.DeptId == department.DeptId)
                {
                    dep.DeptName = department.DeptName;
                    DepartmentData.EditDepartmentDetails(department);
                }
            }
        }

        public List<Department> GetAllDepartmentNames()
        {
            return DepartmentData.GetAllDepartments();
        }

        public void ExportDepartmentsToPdf(PdfPTable pdfptable, string strPdfPath, string strHeader, DataGridView dataGrid)
        {
            FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Write the table
            PdfPTable table = new PdfPTable(dataGrid.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            //Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, Color.WHITE);
            for (int j = 0; j < dataGrid.Columns.Count; j++)
            {
                table.AddCell(new Phrase(dataGrid.Columns[j].HeaderText));
            }
            table.HeaderRows = 1;
            //table Data
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                for (int k = 0; k < dataGrid.Columns.Count; k++)
                {
                    if (dataGrid[k, i].Value != null)
                    {
                        table.AddCell(new Phrase(dataGrid[k, i].Value.ToString()));
                    }
                }
            }

            document.Add(table);
            document.Close();
        }
    }
}
