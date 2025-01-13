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
    public partial class FrmBilling : Form
    {
        public FrmBilling()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmBilling_Load(object sender, EventArgs e)
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryName,
                x.CategoryId
            }).ToList();

            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }

        private void btnBillList_Click(object sender, EventArgs e)
        {
            var values = db.Spendings.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreatBill_Click(object sender, EventArgs e)
        {

            Spendings spendings = new Spendings();
            spendings.SpendingTitle = txtBillTitle.Text;
            spendings.SpendingAmount = decimal.Parse(txtBİllAmount.Text);
            spendings.SpendingDate = Convert.ToDateTime(txtBillDate.Text);
            spendings.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            db.Spendings.Add(spendings);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşlemi Başarılı");

        }

        private void btnRemoveBill_Click(object sender, EventArgs e)
        {
            int id =int.Parse(txtBillId.Text);
            var removeValue = db.Spendings.Find(id);
            db.Spendings.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme Başarılı Şekilde Sistemden Silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtBillId.Text);
            var updatedValue = db.Spendings.Find(id);
            updatedValue.SpendingTitle = txtBillTitle.Text;
            updatedValue.SpendingAmount = decimal.Parse(txtBİllAmount.Text);
            updatedValue.SpendingDate = Convert.ToDateTime(txtBillDate.Text);
            updatedValue.CategoryId = int.Parse(cmbCategory.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnBanksForm_Click(object sender, EventArgs e)
        {
            FrmBank frm = new FrmBank();
            frm.Show();
            this.Hide();
        }

        private void btnDashboardForm_Click(object sender, EventArgs e)
        {
            FrmDashboard frm = new FrmDashboard();
            frm.Show();
            this.Hide();
        }

        private void BtnCategoryForm_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new FrmCategory();
            frm.Show();
            this.Hide();
        }

        private void BtnInvoicesForm_Click(object sender, EventArgs e)
        {
            FrmInvoices frm = new FrmInvoices();
            frm.Show();
            this.Hide();
        }

        private void BtnBankTransactionsForm_Click(object sender, EventArgs e)
        {
            FrmBankTransactions frm = new FrmBankTransactions();
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
