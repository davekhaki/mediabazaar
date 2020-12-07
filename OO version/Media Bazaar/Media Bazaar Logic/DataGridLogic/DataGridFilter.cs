using System.Windows.Forms;

namespace Media_Bazaar_Logic.DataGridLogic
{
    public static class DataGridFilter
    {
        public static void FilterColumn(DataGridView dataGrid, string column) //method to remove or re-add a column to a data grid
        {
            // ReSharper disable once PossibleNullReferenceException
            if (dataGrid != null) dataGrid.Columns[column].Visible = dataGrid.Columns[column].Visible != true;
        }
    }
}
