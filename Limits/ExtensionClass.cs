using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Limits
{
    static class ExtensionClass
    {
        public static void LoadData(this DataTable table, SqlDataReader reader)
        {
            table.CreateConstrant(reader);
            table.Load(reader);
        }

        private static void CreateConstrant(this DataTable table, SqlDataReader reader)
        {
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow schemaRow in schemaTable.Rows)
            {
                DataColumn column = new DataColumn((string) schemaRow["ColumnName"]);
                    // создание столбца с именем столбца в источнике данных
                column.AllowDBNull = (bool) schemaRow["AllowDbNull"]; // получение значения свойства AllowDBNull
                column.DataType = (Type) schemaRow["DataType"]; // получение значения свойства DataType
                column.Unique = (bool) schemaRow["IsUnique"]; // получение значения свойства Unique
                column.ReadOnly = (bool) schemaRow["IsReadOnly"]; // получение значения свойства Readonly
                column.AutoIncrement = (bool) schemaRow["IsIdentity"]; // получение значения свойства AutoIncrement

                if (column.DataType == typeof(string)) // если поле типа string
                    column.MaxLength = (int) schemaRow["ColumnSize"]; // получить значение свойства MaxLength

                if (column.AutoIncrement == true) // Если поле с автоинкрементом 
                {
                    column.AutoIncrementStep = -1;
                    column.AutoIncrementSeed = 0;
                } // задать свойства AutoIncrementStep и AutoIncrementSeed

                table.Columns.Add(column);
            }
        }
    }
}
