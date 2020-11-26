using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace ArtichokeLogic
{
    public class DataGridFilterLogic
    {
        //class with the logic behind filtering data in the datagridview

        public void FilterColumn(DataGridView dataGrid, string column) //method to remove or re-add a column to a datagrid
        {
            if(dataGrid.Columns[column].Visible == true)
            {
                dataGrid.Columns[column].Visible = false;
            }
            else
            {
                dataGrid.Columns[column].Visible = true;
            }
        }
    }
}
