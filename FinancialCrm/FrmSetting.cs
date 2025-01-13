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
    public partial class FrmSetting : Form
    {
        public FrmSetting()
        {
            InitializeComponent();
        }

        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void FrmSetting_Load(object sender, EventArgs e)
        {

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtUserId.Text);
            string username = txtUsername.Text;
            string password1 = txtPassword.Text;

            var users = db.Users.Find(id);
            if (users.UserId == id && users.Username == username)
            {
                users.Password = password1;
                db.SaveChanges();
                MessageBox.Show("Kullanıcı bilgileri başarılı bir şekilde güncellendi!", "Kullanıcı Bilgileri", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya ID hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
