using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReviewSystem_Coursework
{
    class Utility
    {
        public static void WriteTextFile(string path, string data, bool append = true, int count = 1)
        {
            if (!File.Exists(path))
            {
                var file = File.Create(path);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(path, append: append))
            {
                if (!append)
                {
                    //removing opening bracket "[" from data passed
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                    //remove last bracket "]" from the passed data
                    data = data.Trim().Substring(1, data.Trim().Length - 1);
                }
                if (count != 0)
                {
                    data = data + ",";
                }
                writer.WriteLine(data);

            }
        }
        public static string ReadFromFile(string path)
        {
            if (File.Exists(path))
            {
                string data;
                using (StreamReader reader = new StreamReader(path))
                {
                    data = reader.ReadToEnd();
                }
                if (data != "")
                {
                    data = "[" + data + "]";
                }
                return data;
            }
            return null;
        }
        public static DataTable ConvertToTableData<T>(List<T> data)
        {
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            if (data != null)
            {
                foreach (T item in data)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                    {
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    }
                    table.Rows.Add(row);
                }
            }
            return table;
        }

    }
}
