using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week03Proj01
{
    public partial class FormWeek3: Form
    {
        public FormWeek3()
        {
            InitializeComponent();
        }

        private void btnProcess01_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];
            //배열의 길이는 무조건 상수, 배열의 크기는 변하지 않으므로 다른 배열 크기 사용 가능
            //배열 요소 값은
            //struct는 struct의 기본 값 (int는 0)
            //class는 null의 기본값
            int[] arrIntData = new int[arrTbxData.Length];

            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            for (int i = 0; i < arrTbxData.Length; ++i)
            {
                if (arrTbxData[i].Text != null && arrTbxData[i].Text != "")
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
                else
                {
                    //arrIntData[i] = 0;
                }
            }

            int result = 0;

            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; ++i)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];

                for (int i = 1; i < arrIntData.Length; ++i)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];

                for (int i = 1; i < arrIntData.Length; ++i)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];

                for (int i = 1; i < arrIntData.Length; ++i)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 나누기가 불가합니다.");
                        return;
                    }
                        result /= arrIntData[i];
                    //if (arrIntData[i] != 0)
                    //{
                    //   result /= arrIntData[i];
                    //}
                }
            }
            else
            {
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess02_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[5];
            int[] arrIntData = new int[arrTbxData.Length];

            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;


            for (int i = 0; i < arrTbxData.Length; ++i)
            {
                //비어있을 때만 true
                //!도 좋으나 디버깅을 할 때 찾기 힘듬
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    arrIntData[i] = int.Parse(arrTbxData[i].Text);
                }
            }

            int result = 0;

            if (rbtAdd.Checked)
            {
                for (int i = 0; i < arrIntData.Length; ++i)
                {
                    result += arrIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = arrIntData[0];

                for (int i = 1; i < arrIntData.Length; ++i)
                {
                    result -= arrIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = arrIntData[0];

                for (int i = 1; i < arrIntData.Length; ++i)
                {
                    result *= arrIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = arrIntData[0];

                for (int i = 1; i < arrIntData.Length; ++i)
                {
                    if (arrIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 나누기가 불가합니다.");
                        return;
                    }
                    result /= arrIntData[i];
                }
            }
            else
            {
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess03_Click(object sender, EventArgs e)
        {
            //Array  vs  List
            //고정길이    가변길이
            //Length     Count
            //공통점: 요소 접근 방법(index)
            //string.Length에서 문자열 마지막의 null은 스킵
            TextBox[] arrTbxData = new TextBox[5];
            //int[] arrIntData = new int[arrTbxData.Length];
            //Generic (일반화) 지원 자료형
            List<int> lsIntData = new List<int>();
            int result = 0;

            arrTbxData[0] = tbxData1;
            arrTbxData[1] = tbxData2;
            arrTbxData[2] = tbxData3;
            arrTbxData[3] = tbxData4;
            arrTbxData[4] = tbxData5;

            for (int i = 0; i < arrTbxData.Length; ++i)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    //lsIntData[i] = int.Parse(arrTbxData[i].Text);
                    //Add, Insert, Remove
                    lsIntData.Add(int.Parse(arrTbxData[i].Text));
                }
            }


            if (rbtAdd.Checked)
            {
                for (int i = 0; i < lsIntData.Count; ++i)
                {
                    result += lsIntData[i];
                }
            }
            else if (rbtSub.Checked)
            {
                result = lsIntData[0];

                for (int i = 1; i < lsIntData.Count; ++i)
                {
                    result -= lsIntData[i];
                }
            }
            else if (rbtMul.Checked)
            {
                result = lsIntData[0];

                for (int i = 1; i < lsIntData.Count; ++i)
                {
                    result *= lsIntData[i];
                }
            }
            else if (rbtDiv.Checked)
            {
                result = lsIntData[0];

                for (int i = 1; i < lsIntData.Count; ++i)
                {
                    if (lsIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 나누기가 불가합니다.");
                        return;
                    }
                    result /= lsIntData[i];
                }
            }
            else
            {
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }

            lblResult.Text = result.ToString();
        }

        private void btnProcess04_Click(object sender, EventArgs e)
        {
            TextBox[] arrTbxData = new TextBox[] {
                tbxData1, tbxData2, tbxData3, tbxData4, tbxData5
            };
            List<int> lsIntData = new List<int>();
            int result = 0;
            string total_result = "";

            for (int i = 0; i < arrTbxData.Length; ++i)
            {
                if (false == string.IsNullOrEmpty(arrTbxData[i].Text))
                {
                    lsIntData.Add(int.Parse(arrTbxData[i].Text));
                }
            }

            if (!chkAdd.Checked &&
                !chkSub.Checked &&
                !chkMul.Checked &&
                !chkDiv.Checked)
            {
                MessageBox.Show("체크박스에서 연산을 선택하여 주세요.");
                return;
            }


            if (chkAdd.Checked)
            {
                for (int i = 0; i < lsIntData.Count; ++i)
                {
                    result += lsIntData[i];
                }

                total_result += $"더하기{result}";
                total_result += "\r\n"; //or Enviroment.NewLine()

            }
            
            if (chkSub.Checked)
            {
                result = lsIntData[0];

                for (int i = 1; i < lsIntData.Count; ++i)
                {
                    result -= lsIntData[i];
                }

                total_result += $"빼기{result}";
                total_result += "\r\n";
            }
            
            if (chkMul.Checked)
            {
                result = lsIntData[0];

                for (int i = 1; i < lsIntData.Count; ++i)
                {
                    result *= lsIntData[i];
                }

                total_result += $"곱하기{result}";
                total_result += "\r\n";
            }
           
            if (chkDiv.Checked)
            {
                result = lsIntData[0];

                for (int i = 1; i < lsIntData.Count; ++i)
                {
                    if (lsIntData[i] == 0)
                    {
                        arrTbxData[i].Focus();
                        MessageBox.Show("0은 나누기가 불가합니다.");
                        return;
                    }
                    result /= lsIntData[i];
                }

                total_result += $"나누기{result}";
                total_result += "\r\n";
            }
            else
            {
                MessageBox.Show("연산을 선택해주세요.");
                return;
            }

            lblResult.Text = total_result;
        }

        private void FormWeek3_Load(object sender, EventArgs e)
        {

        }

        private void chkOption_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton[] radioButtons =
            {
                rbtAdd,
                rbtSub,
                rbtMul,
                rbtDiv
            };

            List<CheckBox> checkBoxes = new List<CheckBox>
            {
                chkAdd,
                chkSub,
                chkMul,
                chkDiv
            };

            var isEng = chkOption.Checked;
            string word;

            for (int i = 0; i < radioButtons.Length; i++)
            {
                switch(i)
                {
                    case 0: word = isEng ? "Add" : "더하기";
                        break;
                    case 1:
                        word = isEng ? "Sub" : "빼기";
                        break;
                    case 2:
                        word = isEng ? "Mul" : "곱하기";
                        break;
                    case 3:
                        word = isEng ? "Div" : "나누기";
                        break;
                    default: continue;
                }

                radioButtons[i].Text = word;
                checkBoxes[i].Text = word;
            }
        }

        private void btnProcess06_Click(object sender, EventArgs e)
        {
            //미선택 콤보박스의 인덱스 값은 -1
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택해주세요.");
                return;
            }

            //콤보박스의 아이템 값은 가변
            //int cnt = cmbBeverage.Items.Count;

            int price = 0;

            switch (cmbBeverage.SelectedItem.ToString())
            {
                case "아메리카노": price = 1500;
                    break;
                case "카페라떼": price = 2000;
                    break;
                case "플랫화이트": price = 3000;
                    break;
                default: return;
            }

            //가변 자료형
            var iceOption = chkIce.Checked ? "아이스" : "";
            var icePrice = chkIce.Checked ? 500 : 0;

            //icePrice = "100";

            lblResult.Text = $"{iceOption}{cmbBeverage.SelectedItem}: " +
                             $"{price + icePrice}";
        }

        private void btnProcess07_Click(object sender, EventArgs e)
        {
            if (cmbBeverage.SelectedIndex < 0)
            {
                MessageBox.Show("음료를 선택해주세요.");
                return;
            }

            int price = 0;

            switch (cmbBeverage.SelectedIndex)
            {
                case 0: price = 1500;
                    break;
                case 1: price = 2000;
                    break;
                case 2: price = 3000;
                    break;
                default: return;
            }

            var iceOption = chkIce.Checked ? "아이스" : "";
            var icePrice = chkIce.Checked ? 500 : 0;

            lblResult.Text = $"{iceOption}{cmbBeverage.SelectedItem}: " +
                             $"{price + icePrice}";
        }
    }
}
