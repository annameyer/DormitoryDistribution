using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DormitoryDistribution
{
    public class GenerateExcel
    {
        public static DataSet GenerateExcelFile<T>(IEnumerable<T> data)
        {
            DataSet ds = new DataSet("New_DataSet");
            DataTable dt = new DataTable("New_DataTable");
            List<System.Reflection.PropertyInfo> props = typeof(T).GetProperties().ToList();
            DataTable table = new DataTable();
            for (int i = 0; i < props.Count; i++)
            {
                var prop = props[i];
                if (prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(System.Nullable<>) || prop.ToString().Contains("DormitoryDistribution.DB"))
                    table.Columns.Add(prop.Name, prop.PropertyType.GetGenericArguments()[0]);
                else
                    table.Columns.Add(prop.Name, prop.PropertyType);
            }

            object[] values = new object[props.Count];
            foreach (T item in data)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                table.Rows.Add(values);
            }
            ds.Tables.Add(table);
            
            return ds;
        }
    }
}