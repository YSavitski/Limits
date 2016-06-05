using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Limits;

namespace Limits
{
    public partial class MainForm : Form
    {
        string conStr = @"Data Source=ESAVITSKY; Initial Catalog=LimitsDB; Integrated Security=True; Pooling = true;";
        private DataSet dsLimitBankDS;
        private DataTable tbBankInfoLimit;

        public MainForm()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnAddBank_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult result = new AddBank().ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dsLimitBankDS = new DataSet("dsLimitBank");
            DataTable tbBankInfoLimit = new DataTable("tbBankInfoLimit");
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), "Connection eorror", MessageBoxButtons.RetryCancel);
                }

                SqlCommand cmd_GetDataBankInfoLimit = new SqlCommand(string.Format("SELECT BankName, BaseAc, OverallLimit, NCRate, NCLimit, NostroLimit, " +
                                                                                   "CredOper1DayLimit, ForexLimit, CashLimit, SecutitiesLimit, " +
                                                                                   "OthersLimit, LastModifyRow " +
                                                                                   "FROM BankInfoLimit"), connection);
                //SqlDataReader readerBIL = cmd_GetDataBankInfoLimit.ExecuteReader();
                //tbBankInfoLimit.LoadData(readerBIL);
                //readerBIL.Close();
                SqlDataAdapter adapterBIL = new SqlDataAdapter(cmd_GetDataBankInfoLimit.CommandText, connection);
                adapterBIL.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                adapterBIL.FillSchema(tbBankInfoLimit, SchemaType.Mapped);
                adapterBIL.Fill(tbBankInfoLimit);
            }

            
            tbBankInfoLimit.PrimaryKey = new DataColumn[] {tbBankInfoLimit.Columns[1]};
            //dgvLimitListBanks.DataSource = tbBankInfoLimit;
            dgvLimitListBanks.DataSource = tbBankInfoLimit;
        }
    }
}
