using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Limits
{
    public partial class AddBank : Form
    {
        private DataTable tbAddBank;
        public AddBank(DataTable table)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.tbAddBank = table;

            tbBaseAc.Clear();
            tbBankName.Clear();
            tbOverallLimit.Clear();
            tbActualCredPos.Clear();
            tbNCRate.Clear();
            tbNCLimit.Clear();
            tbNostroLimit.Clear();
            tbCredOper1day.Clear();
            tbForexLimit.Clear();
            tbCashLimit.Clear();
            tbSecuritiesLimit.Clear();
        }

        private void AddBank_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnAddBankOK_Click(object sender, EventArgs e)
        {
            DataRow newBank = tbAddBank.NewRow();
            newBank["BankName"] = tbBankName.Text.Count() == 0 ? null : tbBankName.Text;
            newBank["BaseAc"] = tbBaseAc.Text.Count() == 0 ? null : tbBaseAc.Text;
            newBank["OverallLimit"] = tbOverallLimit.Text.Count() == 0 ? null : tbOverallLimit.Text;
            newBank["NCRate"] = tbNCRate.Text.Count() == 0 ? "100.00" : tbNCRate.Text;
            newBank["NostroLimit"] = tbNostroLimit.Text.Count() == 0 ? null : tbNostroLimit.Text;
            newBank["ActualCredPos"] = tbActualCredPos.Text;
            newBank["CredOPer1day"] = tbCredOper1day.Text.Count() == 0 ? null : tbCredOper1day.Text;
            newBank["ForexLimit"] = tbForexLimit.Text.Count() == 0 ? null : tbForexLimit.Text;
            newBank["CashLimit"] = tbCashLimit.Text.Count() == 0 ? null : tbCashLimit.Text;
            newBank["SecuritiesLimit"] = tbSecuritiesLimit.Text.Count() == 0 ? null : tbSecuritiesLimit.Text;
            newBank["LastModifyRow"] = DateTime.Now;
            try
            {
                tbAddBank.Rows.Add(newBank);

                DialogResult = System.Windows.Forms.DialogResult.OK;

                BankUpdates.InsertBank(tbAddBank);
                //CustomersUpdates.InsertCustomers(table);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0}: {1}", DateTime.Now, ex.Message), "Inserting error", MessageBoxButtons.RetryCancel);
            }
            finally
            {
                this.Close();
            }
        }
    }
}
