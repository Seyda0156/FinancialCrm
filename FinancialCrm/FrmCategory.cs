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
    public partial class FrmCategory : Form
    {
        public FrmCategory()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmCategory_Load(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCategoryList_Click(object sender, EventArgs e)
        {
            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnCreatCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            
            Categories categories = new Categories();
            categories.CategoryName = name;
            db.Categories.Add(categories);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sisteme Eklendi");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnRemoveCategory_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtCategoryId.Text);
            var removeValue = db.Categories.Find(id);
            db.Categories.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Şekilde Sistemden Silindi");

            var values = db.Categories.ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            string name = txtCategoryName.Text;
            int id = int.Parse(txtCategoryId.Text);

            var values = db.Categories.Find(id);

            values.CategoryName = name;

            db.SaveChanges();
            MessageBox.Show("Kategori Başarılı Bir Şekilde Sistemde Güncellendi");

            var values2 = db.Categories.ToList();
            dataGridView1.DataSource = values2;
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

        private void BtnBillForm_Click(object sender, EventArgs e)
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
