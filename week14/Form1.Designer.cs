namespace Proj_FinacialLedger_202444086
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSummit = new System.Windows.Forms.Button();
            this.lbxSearch = new System.Windows.Forms.ListBox();
            this.lblIncome = new System.Windows.Forms.Label();
            this.tbxIncomeYears = new System.Windows.Forms.TextBox();
            this.lblExpenditure = new System.Windows.Forms.Label();
            this.btnExoenditure = new System.Windows.Forms.Button();
            this.tbxExpenditureMoney = new System.Windows.Forms.TextBox();
            this.tbxExpenditureYears = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbxSearchMoney = new System.Windows.Forms.TextBox();
            this.tbxSearchYear = new System.Windows.Forms.TextBox();
            this.tbxIncomeMoney = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpgSetup = new System.Windows.Forms.TabPage();
            this.lblTargetAmount = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.tbxTargetAmount = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxYear = new System.Windows.Forms.TextBox();
            this.tpgPushnSearch = new System.Windows.Forms.TabPage();
            this.lbxFinacialedger = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpgSetup.SuspendLayout();
            this.tpgPushnSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSummit
            // 
            this.btnSummit.Font = new System.Drawing.Font("굴림", 15F);
            this.btnSummit.Location = new System.Drawing.Point(4, 108);
            this.btnSummit.Name = "btnSummit";
            this.btnSummit.Size = new System.Drawing.Size(225, 44);
            this.btnSummit.TabIndex = 1;
            this.btnSummit.Text = "Summit";
            this.btnSummit.UseVisualStyleBackColor = true;
            this.btnSummit.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // lbxSearch
            // 
            this.lbxSearch.Font = new System.Drawing.Font("굴림", 11F);
            this.lbxSearch.FormattingEnabled = true;
            this.lbxSearch.ItemHeight = 15;
            this.lbxSearch.Location = new System.Drawing.Point(4, 159);
            this.lbxSearch.Name = "lbxSearch";
            this.lbxSearch.Size = new System.Drawing.Size(740, 199);
            this.lbxSearch.TabIndex = 3;
            // 
            // lblIncome
            // 
            this.lblIncome.Font = new System.Drawing.Font("굴림", 15F);
            this.lblIncome.Location = new System.Drawing.Point(3, 3);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(225, 31);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "Income";
            this.lblIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxIncomeYears
            // 
            this.tbxIncomeYears.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxIncomeYears.Location = new System.Drawing.Point(4, 37);
            this.tbxIncomeYears.Name = "tbxIncomeYears";
            this.tbxIncomeYears.Size = new System.Drawing.Size(225, 30);
            this.tbxIncomeYears.TabIndex = 2;
            // 
            // lblExpenditure
            // 
            this.lblExpenditure.Font = new System.Drawing.Font("굴림", 15F);
            this.lblExpenditure.Location = new System.Drawing.Point(259, 3);
            this.lblExpenditure.Name = "lblExpenditure";
            this.lblExpenditure.Size = new System.Drawing.Size(225, 31);
            this.lblExpenditure.TabIndex = 0;
            this.lblExpenditure.Text = "Expenditure";
            this.lblExpenditure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExoenditure
            // 
            this.btnExoenditure.Font = new System.Drawing.Font("굴림", 15F);
            this.btnExoenditure.Location = new System.Drawing.Point(260, 108);
            this.btnExoenditure.Name = "btnExoenditure";
            this.btnExoenditure.Size = new System.Drawing.Size(225, 44);
            this.btnExoenditure.TabIndex = 1;
            this.btnExoenditure.Text = "Summit";
            this.btnExoenditure.UseVisualStyleBackColor = true;
            this.btnExoenditure.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // tbxExpenditureMoney
            // 
            this.tbxExpenditureMoney.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxExpenditureMoney.Location = new System.Drawing.Point(260, 72);
            this.tbxExpenditureMoney.Name = "tbxExpenditureMoney";
            this.tbxExpenditureMoney.Size = new System.Drawing.Size(225, 30);
            this.tbxExpenditureMoney.TabIndex = 2;
            // 
            // tbxExpenditureYears
            // 
            this.tbxExpenditureYears.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxExpenditureYears.Location = new System.Drawing.Point(260, 37);
            this.tbxExpenditureYears.Name = "tbxExpenditureYears";
            this.tbxExpenditureYears.Size = new System.Drawing.Size(225, 30);
            this.tbxExpenditureYears.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.Font = new System.Drawing.Font("굴림", 15F);
            this.lblSearch.Location = new System.Drawing.Point(519, 4);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(225, 31);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 15F);
            this.btnSearch.Location = new System.Drawing.Point(520, 109);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(225, 44);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSummit_Click);
            // 
            // tbxSearchMoney
            // 
            this.tbxSearchMoney.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxSearchMoney.Location = new System.Drawing.Point(520, 73);
            this.tbxSearchMoney.Name = "tbxSearchMoney";
            this.tbxSearchMoney.Size = new System.Drawing.Size(225, 30);
            this.tbxSearchMoney.TabIndex = 2;
            // 
            // tbxSearchYear
            // 
            this.tbxSearchYear.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxSearchYear.Location = new System.Drawing.Point(520, 38);
            this.tbxSearchYear.Name = "tbxSearchYear";
            this.tbxSearchYear.Size = new System.Drawing.Size(225, 30);
            this.tbxSearchYear.TabIndex = 2;
            // 
            // tbxIncomeMoney
            // 
            this.tbxIncomeMoney.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxIncomeMoney.Location = new System.Drawing.Point(4, 72);
            this.tbxIncomeMoney.Name = "tbxIncomeMoney";
            this.tbxIncomeMoney.Size = new System.Drawing.Size(225, 30);
            this.tbxIncomeMoney.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpgSetup);
            this.tabControl1.Controls.Add(this.tpgPushnSearch);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 398);
            this.tabControl1.TabIndex = 4;
            // 
            // tpgSetup
            // 
            this.tpgSetup.Controls.Add(this.lbxFinacialedger);
            this.tpgSetup.Controls.Add(this.lblTargetAmount);
            this.tpgSetup.Controls.Add(this.lblYear);
            this.tpgSetup.Controls.Add(this.tbxTargetAmount);
            this.tpgSetup.Controls.Add(this.btnAdd);
            this.tpgSetup.Controls.Add(this.tbxYear);
            this.tpgSetup.Location = new System.Drawing.Point(4, 22);
            this.tpgSetup.Name = "tpgSetup";
            this.tpgSetup.Padding = new System.Windows.Forms.Padding(3);
            this.tpgSetup.Size = new System.Drawing.Size(761, 372);
            this.tpgSetup.TabIndex = 0;
            this.tpgSetup.Text = "Setup";
            this.tpgSetup.UseVisualStyleBackColor = true;
            // 
            // lblTargetAmount
            // 
            this.lblTargetAmount.Font = new System.Drawing.Font("굴림", 15F);
            this.lblTargetAmount.Location = new System.Drawing.Point(147, 78);
            this.lblTargetAmount.Name = "lblTargetAmount";
            this.lblTargetAmount.Size = new System.Drawing.Size(225, 31);
            this.lblTargetAmount.TabIndex = 3;
            this.lblTargetAmount.Text = "TargetAmount";
            this.lblTargetAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            this.lblYear.Font = new System.Drawing.Font("굴림", 15F);
            this.lblYear.Location = new System.Drawing.Point(147, 26);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(225, 31);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Year";
            this.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxTargetAmount
            // 
            this.tbxTargetAmount.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxTargetAmount.Location = new System.Drawing.Point(378, 80);
            this.tbxTargetAmount.Name = "tbxTargetAmount";
            this.tbxTargetAmount.Size = new System.Drawing.Size(225, 30);
            this.tbxTargetAmount.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("굴림", 15F);
            this.btnAdd.Location = new System.Drawing.Point(259, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(225, 44);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxYear
            // 
            this.tbxYear.Font = new System.Drawing.Font("굴림", 15F);
            this.tbxYear.Location = new System.Drawing.Point(378, 28);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(225, 30);
            this.tbxYear.TabIndex = 5;
            // 
            // tpgPushnSearch
            // 
            this.tpgPushnSearch.Controls.Add(this.lblIncome);
            this.tpgPushnSearch.Controls.Add(this.lbxSearch);
            this.tpgPushnSearch.Controls.Add(this.btnSummit);
            this.tpgPushnSearch.Controls.Add(this.tbxSearchYear);
            this.tpgPushnSearch.Controls.Add(this.lblExpenditure);
            this.tpgPushnSearch.Controls.Add(this.tbxExpenditureYears);
            this.tpgPushnSearch.Controls.Add(this.btnExoenditure);
            this.tpgPushnSearch.Controls.Add(this.tbxIncomeYears);
            this.tpgPushnSearch.Controls.Add(this.lblSearch);
            this.tpgPushnSearch.Controls.Add(this.tbxSearchMoney);
            this.tpgPushnSearch.Controls.Add(this.btnSearch);
            this.tpgPushnSearch.Controls.Add(this.tbxExpenditureMoney);
            this.tpgPushnSearch.Controls.Add(this.tbxIncomeMoney);
            this.tpgPushnSearch.Location = new System.Drawing.Point(4, 22);
            this.tpgPushnSearch.Name = "tpgPushnSearch";
            this.tpgPushnSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpgPushnSearch.Size = new System.Drawing.Size(761, 372);
            this.tpgPushnSearch.TabIndex = 1;
            this.tpgPushnSearch.Text = "PushnSearch";
            this.tpgPushnSearch.UseVisualStyleBackColor = true;
            // 
            // lbxFinacialedger
            // 
            this.lbxFinacialedger.Font = new System.Drawing.Font("굴림", 11F);
            this.lbxFinacialedger.FormattingEnabled = true;
            this.lbxFinacialedger.HorizontalScrollbar = true;
            this.lbxFinacialedger.ItemHeight = 15;
            this.lbxFinacialedger.Location = new System.Drawing.Point(12, 197);
            this.lbxFinacialedger.Name = "lbxFinacialedger";
            this.lbxFinacialedger.Size = new System.Drawing.Size(740, 169);
            this.lbxFinacialedger.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 399);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpgSetup.ResumeLayout(false);
            this.tpgSetup.PerformLayout();
            this.tpgPushnSearch.ResumeLayout(false);
            this.tpgPushnSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSummit;
        private System.Windows.Forms.ListBox lbxSearch;
        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.TextBox tbxIncomeYears;
        private System.Windows.Forms.Label lblExpenditure;
        private System.Windows.Forms.Button btnExoenditure;
        private System.Windows.Forms.TextBox tbxExpenditureMoney;
        private System.Windows.Forms.TextBox tbxExpenditureYears;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxSearchMoney;
        private System.Windows.Forms.TextBox tbxSearchYear;
        private System.Windows.Forms.TextBox tbxIncomeMoney;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpgSetup;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxYear;
        private System.Windows.Forms.TabPage tpgPushnSearch;
        private System.Windows.Forms.Label lblTargetAmount;
        private System.Windows.Forms.TextBox tbxTargetAmount;
        private System.Windows.Forms.ListBox lbxFinacialedger;
    }
}

