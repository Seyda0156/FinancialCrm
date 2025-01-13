namespace FinancialCrm
{
    partial class FrmBankTransactions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnExitForm = new System.Windows.Forms.Button();
            this.btnDashboardForm = new System.Windows.Forms.Button();
            this.BtnSettingForm = new System.Windows.Forms.Button();
            this.BtnBankTransactionsForm = new System.Windows.Forms.Button();
            this.btnBillForm = new System.Windows.Forms.Button();
            this.BtnInvoicesForm = new System.Windows.Forms.Button();
            this.btnBanksForm = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.rdbGidenHavale = new System.Windows.Forms.RadioButton();
            this.rdbGelenHavale = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBankTransactionsAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.btnRemoveBill = new System.Windows.Forms.Button();
            this.btnCreatBill = new System.Windows.Forms.Button();
            this.btnBillList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBankTransactionsDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBankTransactionsDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBankTransactionsId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(57)))), ((int)(((byte)(82)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 38);
            this.panel2.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Banka Haraketleri";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(98)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.BtnExitForm);
            this.panel1.Controls.Add(this.btnDashboardForm);
            this.panel1.Controls.Add(this.BtnSettingForm);
            this.panel1.Controls.Add(this.BtnBankTransactionsForm);
            this.panel1.Controls.Add(this.btnBillForm);
            this.panel1.Controls.Add(this.BtnInvoicesForm);
            this.panel1.Controls.Add(this.btnBanksForm);
            this.panel1.Controls.Add(this.btnCategory);
            this.panel1.Location = new System.Drawing.Point(1, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 511);
            this.panel1.TabIndex = 11;
            // 
            // BtnExitForm
            // 
            this.BtnExitForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExitForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnExitForm.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExitForm.Location = new System.Drawing.Point(16, 351);
            this.BtnExitForm.Name = "BtnExitForm";
            this.BtnExitForm.Size = new System.Drawing.Size(165, 41);
            this.BtnExitForm.TabIndex = 4;
            this.BtnExitForm.Text = "Çıkış Yap";
            this.BtnExitForm.UseVisualStyleBackColor = true;
            this.BtnExitForm.Click += new System.EventHandler(this.BtnExitForm_Click);
            // 
            // btnDashboardForm
            // 
            this.btnDashboardForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboardForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDashboardForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashboardForm.Location = new System.Drawing.Point(16, 257);
            this.btnDashboardForm.Name = "btnDashboardForm";
            this.btnDashboardForm.Size = new System.Drawing.Size(165, 41);
            this.btnDashboardForm.TabIndex = 2;
            this.btnDashboardForm.Text = "Dashboard";
            this.btnDashboardForm.UseVisualStyleBackColor = true;
            this.btnDashboardForm.Click += new System.EventHandler(this.btnDashboardForm_Click);
            // 
            // BtnSettingForm
            // 
            this.BtnSettingForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSettingForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSettingForm.ForeColor = System.Drawing.Color.Transparent;
            this.BtnSettingForm.Location = new System.Drawing.Point(16, 304);
            this.BtnSettingForm.Name = "BtnSettingForm";
            this.BtnSettingForm.Size = new System.Drawing.Size(165, 41);
            this.BtnSettingForm.TabIndex = 3;
            this.BtnSettingForm.Text = "Ayarlar";
            this.BtnSettingForm.UseVisualStyleBackColor = true;
            this.BtnSettingForm.Click += new System.EventHandler(this.BtnSettingForm_Click);
            // 
            // BtnBankTransactionsForm
            // 
            this.BtnBankTransactionsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBankTransactionsForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnBankTransactionsForm.ForeColor = System.Drawing.Color.Transparent;
            this.BtnBankTransactionsForm.Location = new System.Drawing.Point(16, 210);
            this.BtnBankTransactionsForm.Name = "BtnBankTransactionsForm";
            this.BtnBankTransactionsForm.Size = new System.Drawing.Size(165, 41);
            this.BtnBankTransactionsForm.TabIndex = 2;
            this.BtnBankTransactionsForm.Text = "Banka Haraketleri";
            this.BtnBankTransactionsForm.UseVisualStyleBackColor = true;
            this.BtnBankTransactionsForm.Click += new System.EventHandler(this.BtnBankTransactionsForm_Click);
            // 
            // btnBillForm
            // 
            this.btnBillForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillForm.Location = new System.Drawing.Point(16, 163);
            this.btnBillForm.Name = "btnBillForm";
            this.btnBillForm.Size = new System.Drawing.Size(165, 41);
            this.btnBillForm.TabIndex = 2;
            this.btnBillForm.Text = "Giderler";
            this.btnBillForm.UseVisualStyleBackColor = true;
            this.btnBillForm.Click += new System.EventHandler(this.btnBillForm_Click);
            // 
            // BtnInvoicesForm
            // 
            this.BtnInvoicesForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInvoicesForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnInvoicesForm.ForeColor = System.Drawing.Color.Transparent;
            this.BtnInvoicesForm.Location = new System.Drawing.Point(16, 116);
            this.BtnInvoicesForm.Name = "BtnInvoicesForm";
            this.BtnInvoicesForm.Size = new System.Drawing.Size(165, 41);
            this.BtnInvoicesForm.TabIndex = 2;
            this.BtnInvoicesForm.Text = "Faturalar";
            this.BtnInvoicesForm.UseVisualStyleBackColor = true;
            this.BtnInvoicesForm.Click += new System.EventHandler(this.BtnInvoicesForm_Click);
            // 
            // btnBanksForm
            // 
            this.btnBanksForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanksForm.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanksForm.ForeColor = System.Drawing.Color.Transparent;
            this.btnBanksForm.Location = new System.Drawing.Point(16, 69);
            this.btnBanksForm.Name = "btnBanksForm";
            this.btnBanksForm.Size = new System.Drawing.Size(165, 41);
            this.btnBanksForm.TabIndex = 1;
            this.btnBanksForm.Text = "Bankalar";
            this.btnBanksForm.UseVisualStyleBackColor = true;
            this.btnBanksForm.Click += new System.EventHandler(this.btnBanksForm_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategory.Location = new System.Drawing.Point(16, 22);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(165, 41);
            this.btnCategory.TabIndex = 0;
            this.btnCategory.Text = "Kategoriler";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbBank);
            this.panel3.Controls.Add(this.rdbGidenHavale);
            this.panel3.Controls.Add(this.rdbGelenHavale);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtBankTransactionsAmount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btnUpdateBill);
            this.panel3.Controls.Add(this.btnRemoveBill);
            this.panel3.Controls.Add(this.btnCreatBill);
            this.panel3.Controls.Add(this.btnBillList);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtBankTransactionsDate);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBankTransactionsDescription);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtBankTransactionsId);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(209, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 255);
            this.panel3.TabIndex = 13;
            // 
            // cmbBank
            // 
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(103, 153);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(186, 24);
            this.cmbBank.TabIndex = 21;
            // 
            // rdbGidenHavale
            // 
            this.rdbGidenHavale.AutoSize = true;
            this.rdbGidenHavale.Location = new System.Drawing.Point(223, 100);
            this.rdbGidenHavale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGidenHavale.Name = "rdbGidenHavale";
            this.rdbGidenHavale.Size = new System.Drawing.Size(111, 20);
            this.rdbGidenHavale.TabIndex = 20;
            this.rdbGidenHavale.TabStop = true;
            this.rdbGidenHavale.Text = "Giden Havale";
            this.rdbGidenHavale.UseVisualStyleBackColor = true;
            // 
            // rdbGelenHavale
            // 
            this.rdbGelenHavale.AutoSize = true;
            this.rdbGelenHavale.Location = new System.Drawing.Point(103, 100);
            this.rdbGelenHavale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbGelenHavale.Name = "rdbGelenHavale";
            this.rdbGelenHavale.Size = new System.Drawing.Size(111, 20);
            this.rdbGelenHavale.TabIndex = 19;
            this.rdbGelenHavale.TabStop = true;
            this.rdbGelenHavale.Text = "Gelen Havale";
            this.rdbGelenHavale.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Banka";
            // 
            // txtBankTransactionsAmount
            // 
            this.txtBankTransactionsAmount.Location = new System.Drawing.Point(103, 128);
            this.txtBankTransactionsAmount.Name = "txtBankTransactionsAmount";
            this.txtBankTransactionsAmount.Size = new System.Drawing.Size(466, 22);
            this.txtBankTransactionsAmount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Miktar";
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.BackColor = System.Drawing.Color.Black;
            this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBill.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateBill.Location = new System.Drawing.Point(462, 202);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(146, 41);
            this.btnUpdateBill.TabIndex = 14;
            this.btnUpdateBill.Text = "Güncelle";
            this.btnUpdateBill.UseVisualStyleBackColor = false;
            this.btnUpdateBill.Click += new System.EventHandler(this.btnUpdateBill_Click);
            // 
            // btnRemoveBill
            // 
            this.btnRemoveBill.BackColor = System.Drawing.Color.Black;
            this.btnRemoveBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveBill.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveBill.Location = new System.Drawing.Point(310, 202);
            this.btnRemoveBill.Name = "btnRemoveBill";
            this.btnRemoveBill.Size = new System.Drawing.Size(146, 41);
            this.btnRemoveBill.TabIndex = 13;
            this.btnRemoveBill.Text = "İşlem Sil";
            this.btnRemoveBill.UseVisualStyleBackColor = false;
            this.btnRemoveBill.Click += new System.EventHandler(this.btnRemoveBill_Click);
            // 
            // btnCreatBill
            // 
            this.btnCreatBill.BackColor = System.Drawing.Color.Black;
            this.btnCreatBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatBill.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreatBill.ForeColor = System.Drawing.Color.Transparent;
            this.btnCreatBill.Location = new System.Drawing.Point(158, 202);
            this.btnCreatBill.Name = "btnCreatBill";
            this.btnCreatBill.Size = new System.Drawing.Size(146, 41);
            this.btnCreatBill.TabIndex = 12;
            this.btnCreatBill.Text = "Yeni işlem";
            this.btnCreatBill.UseVisualStyleBackColor = false;
            this.btnCreatBill.Click += new System.EventHandler(this.btnCreatBill_Click);
            // 
            // btnBillList
            // 
            this.btnBillList.BackColor = System.Drawing.Color.Black;
            this.btnBillList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBillList.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBillList.ForeColor = System.Drawing.Color.Transparent;
            this.btnBillList.Location = new System.Drawing.Point(6, 202);
            this.btnBillList.Name = "btnBillList";
            this.btnBillList.Size = new System.Drawing.Size(146, 41);
            this.btnBillList.TabIndex = 5;
            this.btnBillList.Text = "İşlem Listesi";
            this.btnBillList.UseVisualStyleBackColor = false;
            this.btnBillList.Click += new System.EventHandler(this.btnBillList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "İşlem Tipi";
            // 
            // txtBankTransactionsDate
            // 
            this.txtBankTransactionsDate.Location = new System.Drawing.Point(103, 73);
            this.txtBankTransactionsDate.Name = "txtBankTransactionsDate";
            this.txtBankTransactionsDate.Size = new System.Drawing.Size(466, 22);
            this.txtBankTransactionsDate.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "İşlem Tarihi";
            // 
            // txtBankTransactionsDescription
            // 
            this.txtBankTransactionsDescription.Location = new System.Drawing.Point(103, 45);
            this.txtBankTransactionsDescription.Name = "txtBankTransactionsDescription";
            this.txtBankTransactionsDescription.Size = new System.Drawing.Size(466, 22);
            this.txtBankTransactionsDescription.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Açıklama";
            // 
            // txtBankTransactionsId
            // 
            this.txtBankTransactionsId.Location = new System.Drawing.Point(103, 17);
            this.txtBankTransactionsId.Name = "txtBankTransactionsId";
            this.txtBankTransactionsId.Size = new System.Drawing.Size(466, 22);
            this.txtBankTransactionsId.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "İşlem Id";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Location = new System.Drawing.Point(209, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 245);
            this.panel4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 245);
            this.dataGridView1.TabIndex = 0;
            // 
            // FrmBankTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 547);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBankTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBankTransactions";
            this.Load += new System.EventHandler(this.FrmBankTransactions_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnExitForm;
        private System.Windows.Forms.Button btnDashboardForm;
        private System.Windows.Forms.Button BtnSettingForm;
        private System.Windows.Forms.Button BtnBankTransactionsForm;
        private System.Windows.Forms.Button btnBillForm;
        private System.Windows.Forms.Button BtnInvoicesForm;
        private System.Windows.Forms.Button btnBanksForm;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Button btnRemoveBill;
        private System.Windows.Forms.Button btnCreatBill;
        private System.Windows.Forms.Button btnBillList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBankTransactionsDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBankTransactionsDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBankTransactionsId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rdbGidenHavale;
        private System.Windows.Forms.RadioButton rdbGelenHavale;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBankTransactionsAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBank;
    }
}