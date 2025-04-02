using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week04Homework
{
    public partial class FormManager: Form
    {
        //instance field or memeber var
        Department[] departments;
        List<Professor> professors;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어줌
        public FormManager()
        {
            InitializeComponent();

            departments = new Department[100];
            professors = new List<Professor>();
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            //학과코드랑 이름이 비어있으면 안됨(과제)

            Department dept = new Department();

            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            int index = -1;

            for (int i = 0; i < departments.Length; ++i)
            {
                if (departments[i] == null && index < 0)
                {
                        index = i;
                }
                else if (departments[i] == null && departments[i].Code == tbxDepartmentCode.Text)
                {
                    //메시지 띄우기
                    return;
                }
            }

            if (index < 0)
            {
                //메시지 띄우기
                return;
            }

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            //Only use for test
            lbxDepartment.Items.Add(dept.Code);
            lbxDepartment.Items.Add(dept.Name);
            lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                //메시지
                return;
            }

            //is 연산자, 타입 확인용으로 사용
            if (lbxDepartment.SelectedItem is Department)
            {
                var target = (Department)lbxDepartment.SelectedItem;

                for (int i = 0; i < departments.Length; ++i)
                {
                    if (departments[i] != null && departments[i] == target)
                    {
                        departments[i] = null;
                        break;
                    }
                }

                lbxDepartment.Items.RemoveAt(lbxDepartment.SelectedIndex);

                //선택 해제
                lbxDepartment.SelectedIndex = -1;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabMain.SelectedIndex)
            {
                case 0: 
                    break;
                case 1:
                    cmbProfessorDepartment.Items.Clear();
                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbProfessorDepartment.Items.Add(department);
                        }
                    }

                    cmbProfessorDepartment.SelectedIndex = -1;
                    lbxProfessor.Items.Clear();
                    break;
                case 2:
                    break;
                default:
                    break;
            }
        }

        private void cmbProfessorDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxProfessor.Items.Clear();

            //as 형변환 연산자
            //형변환이 정상적이지 않으면 null 반환(struct 계열은 불가)
            var department = cmbProfessorDepartment.SelectedItem as Department;

            if (department == null || cmbProfessorDepartment.SelectedIndex < 0)
            {
                return;
            }

            foreach(var professor in professors)
            {
                if (professor != null && professor.DepartmentCode == department.Code)
                {
                    lbxProfessor.Items.Add(professor);
                }
            }
        }
    }
}
