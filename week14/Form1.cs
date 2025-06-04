using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_FinacialLedger_202444086
{
    public partial class Form1: Form
    {
        Finacialedger finacialedger = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxYear.Text))
            {
                MessageBox.Show("년도가 비어있습니다.");
                tbxYear.Focus();
                return;
            }

            Finacialedger fin = null;
            int year = 0;

            if (int.TryParse(tbxYear.Text, out year))
            {
                if (false == (1900 < year && year < 2100))
                {
                    MessageBox.Show("냔도는 1900에서 2100 사이만 입력 가능합니다.");
                    tbxYear.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("년도는 정수 숫자만 입력 가능합니다.");
                tbxYear.Focus();
                return;
            }

            if (string.IsNullOrEmpty(tbxTargetAmount.Text))
            {
                fin = new Finacialedger(year);
            }
            else
            {
                int targetAmount = 0;

                if (int.TryParse(tbxTargetAmount.Text, out targetAmount))
                {
                    //목표 흑자액에 음수일 경우도 있을 듯
                    if (targetAmount == 0)
                    {
                        fin = new Finacialedger(year);
                        MessageBox.Show("목표 흑자액은 0이외에만 가능합니다.");
                    }

                    fin = new Finacialedger(year, targetAmount);
                }
                else
                {
                    MessageBox.Show("목표 흑자액은 정수 숫자만 입력 가능합니다.");
                    tbxTargetAmount.Focus();
                    return;
                }

                finacialedger = fin;
            }
        }

        private void btnSummit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxIncomeMoney.Text))
            {
                MessageBox.Show("넣으려는 돈이 비어있습니다.");
                tbxIncomeMoney.Focus();
                return;
            }

            int money = int.Parse(tbxIncomeMoney.Text);

        }

    }
}
