using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limits
{
    static class BankUpdates
    {
        private static void InsertBank(DataRow rowBank)
        {
            string connStr =
                @"Data Source=ESAVITSKY; Initial Catalog=LimitsDB; Integrated Security=True; Pooling = true;";
            string strInsertNewBank = "INSERT INTO BankInfoLimit" +
                                      "VALUES ( @BankName, @BaseAc, @OverallLimit, @NCRate, @NCLimit, @ActualCredPos, " +
                                      "@NostroLimit, @CredOper1DayLimit, @ForexLimit, @CashLimit, @SecuritiesLimit, " +
                                      "@OthersLimit, @LastModifyRow)";
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                connection.Open();

                SqlCommand cmd_InsertNewBank = new SqlCommand(strInsertNewBank, connection);
                cmd_InsertNewBank.Parameters.AddWithValue("BankInfo", rowBank[0]);
                cmd_InsertNewBank.Parameters.AddWithValue("BaseAc", rowBank[1]);
                cmd_InsertNewBank.Parameters.AddWithValue("OverallLimit", rowBank[2]);
                cmd_InsertNewBank.Parameters.AddWithValue("NCRate", rowBank[3]);
                cmd_InsertNewBank.Parameters.AddWithValue("NCLimit", rowBank[4]);
                cmd_InsertNewBank.Parameters.AddWithValue("ActualCredPos", rowBank[5]);
                cmd_InsertNewBank.Parameters.AddWithValue("NostroLimit", rowBank[6]);
                cmd_InsertNewBank.Parameters.AddWithValue("CredOper1day", rowBank[7]);
                cmd_InsertNewBank.Parameters.AddWithValue("ForexLimit", rowBank[8]);
                cmd_InsertNewBank.Parameters.AddWithValue("CashLimit", rowBank[9]);
                cmd_InsertNewBank.Parameters.AddWithValue("SecuritiesLimit", rowBank[10]);
                cmd_InsertNewBank.Parameters.AddWithValue("OthersLimit", rowBank[11]);
                cmd_InsertNewBank.Parameters.AddWithValue("LastModifyRow", rowBank[12]);

                try
                {
                    rowBank.SetField<int>(0, (int)cmd_InsertNewBank.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), "Inserting error", MessageBoxButtons.RetryCancel);
                }

                rowBank.AcceptChanges();
            }
        }

        public static void InsertBank(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (row.RowState == DataRowState.Added)
                    InsertBank(row);
            }
        }
    }
}
