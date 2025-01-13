using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinancialCrm.Models;

namespace FinancialCrm
{
    public partial class FrmBankTransactions : Form
    {
        public FrmBankTransactions()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBankTransactions_Load(object sender, EventArgs e)
        {
            var values = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankId
            }).ToList();

            cmbBank.DisplayMember = "BankTitle";
            cmbBank.ValueMember = "BankId";
            cmbBank.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreatBill_Click(object sender, EventArgs e)
        {
            string type = "0";
            if (rdbGelenHavale.Checked) { type = rdbGelenHavale.Text; }
            else if (rdbGidenHavale.Checked) { type = rdbGidenHavale.Text; }

            BankProcesses bankProcesses = new BankProcesses();
            bankProcesses.Description = txtBankTransactionsDescription.Text;
            bankProcesses.Amount = decimal.Parse(txtBankTransactionsAmount.Text);
            bankProcesses.ProcessData = Convert.ToDateTime(txtBankTransactionsDate.Text);
            bankProcesses.BankId = int.Parse(cmbBank.SelectedValue.ToString());
            bankProcesses.ProcessType = type;
            db.BankProcesses.Add(bankProcesses);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");
        }
        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBankTransactionsId.Text);
            var removeValue = db.BankProcesses.Find(id);
            db.BankProcesses.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Silme İşlemi Başarılı");

            var values = db.BankProcesses.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            string type = "0";
            if (rdbGelenHavale.Checked) { type = rdbGelenHavale.Text; }
            else if (rdbGidenHavale.Checked) { type = rdbGidenHavale.Text; }

            int id = int.Parse(txtBankTransactionsId.Text);
            var updatedValue = db.BankProcesses.Find(id);
            updatedValue.Description = txtBankTransactionsDescription.Text;
            updatedValue.Amount = decimal.Parse(txtBankTransactionsAmount.Text);
            updatedValue.ProcessData = Convert.ToDateTime(txtBankTransactionsDate.Text);
            updatedValue.BankId = int.Parse(cmbBank.SelectedValue.ToString());
            updatedValue.ProcessType = type;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }


        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBank frm = new FrmBank();
            frm.Show();
            this.Hide();
        }

        private void BtnInvoicesForm_Click(object sender, EventArgs e)
        {
            FrmInvoices frm = new FrmInvoices();
            frm.Show();
            this.Hide();
        }

        private void btnBillForm_Click(object sender, EventArgs e)
        {
            FrmBilling frm = new FrmBilling();
            frm.Show();
            this.Hide();
        }

        private void BtnBankTransactionsForm_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void BtnSettingForm_Click(object sender, EventArgs e)
        {
            FrmSetting frm = new FrmSetting();
            frm.Show();
            this.Hide();
        }

        private void BtnExitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}