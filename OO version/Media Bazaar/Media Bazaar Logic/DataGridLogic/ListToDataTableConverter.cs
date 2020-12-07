using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

namespace Media_Bazaar_Logic.DataGridLogic
{
    public static class ListToDataTableConverter
    {
        public static DataTable ToDataTable<T>(IList<T> data) //method that converts a list with custom type to data table
        {
            var properties = TypeDescriptor.GetProperties(typeof(T));
            var table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (var item in data)
            {
                var row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
            }
            return table;
        }
    }
}
