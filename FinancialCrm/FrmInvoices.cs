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
    public partial class FrmInvoices : Form
    {
        public FrmInvoices()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnInvoicesList_Click(object sender, EventArgs e)
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreatInvoices_Click(object sender, EventArgs e)
        {
            string title = txtInvoicesTitle.Text;
            decimal amount = decimal.Parse(txtInvoicesAmount.Text);
            string period = txtInvoicesPeriod.Text;

            Bills bills = new Bills();
            bills.BillTitle = title;
            bills.BillPeriod = period;
            bills.BillAmount = amount;
            db.Bills.Add(bills);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sisteme Eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveInvoices_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtInvoicesId.Text);
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateInvoices_Click(object sender, EventArgs e)
        {
            string title = txtInvoicesTitle.Text;
            decimal amount = decimal.Parse(txtInvoicesAmount.Text);
            string period = txtInvoicesPeriod.Text;
            int id = int.Parse(txtInvoicesId.Text);

            var values = db.Bills.Find(id);

            values.BillTitle = title;
            values.BillPeriod = period;
            values.BillAmount = amount;
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Bir Şekilde Sistemde Güncellendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values2 = db.Bills.ToList();
            dataGridView1.DataSource = values2;
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
