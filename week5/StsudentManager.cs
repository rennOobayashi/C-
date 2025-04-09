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
        Dictionary<string, Student> students;
        Student selectedStudent = null;
        List<Grade> testGrades;
        TextBox[] tbxTestScores;

        //생성자
        //인스턴스 생성시 초기화가 필요한 코드를 넣어줌
        public FormManager()
        {
            InitializeComponent();

            departments = new Department[100];
            professors = new List<Professor>();
            students = new Dictionary<string, Student>();
            testGrades = new List<Grade>();
            tbxTestScores = new TextBox[] {
                tbxTestScore1,
                tbxTestScore2,
                tbxTestScore3, 
                tbxTestScore4, 
                tbxTestScore5, 
                tbxTestScore6, 
                tbxTestScore7, 
                tbxTestScore8, 
                tbxTestScore9
            };

            for (int i = 1; i <= 4; ++i)
            {
                cmbYear.Items.Add(i);
            }

            //마땅한 방법이 떠오르지 않았습니다...
            cmbClass.Items.AddRange(new object[] {"A", "B", "C"});

            cmbRegStatus.Items.Add("재학");
            cmbRegStatus.Items.Add("졸업");
            cmbRegStatus.Items.Add("휴학");
            cmbRegStatus.Items.Add("퇴학");
        }

        private void btnRegisterDepartment_Click(object sender, EventArgs e)
        {
            Department dept = new Department();

            dept.Code = tbxDepartmentCode.Text;
            dept.Name = tbxDepartmentName.Text;

            //학과코드랑 이름이 비어있으면 안됨(과제)
            if (dept.Code == "" || dept.Name == "")
            {
                if (dept.Code == "")
                {
                    MessageBox.Show("학과 코드가 비어있습니다.");
                    tbxDepartmentCode.Focus();
                }
                else if (dept.Name == "")
                {
                    MessageBox.Show("이름이 비어있습니다.");
                    tbxDepartmentName.Focus();
                }
                else
                {
                    MessageBox.Show("학과 코드와 이름이 비어있습니다.");
                    tbxDepartmentCode.Focus();
                }

                return;
            }

            int index = -1;

            for (int i = 0; i < departments.Length; ++i)
            {
                if (departments[i] == null && index < 0)
                {
                    index = i;
                }
                else if (departments[i] != null && departments[i].Code == tbxDepartmentCode.Text)
                {
                    MessageBox.Show("이미 등록되어있는 학과입니다.");

                    return;
                }
            }

            if (index < 0)
            {
                MessageBox.Show("학과 리스트가 가득차 있습니다.");

                return;
            }

            departments[index] = dept;

            lbxDepartment.Items.Add(dept);
            //Only use for test
            //lbxDepartment.Items.Add(dept.Code);
            //lbxDepartment.Items.Add(dept.Name);
            //lbxDepartment.Items.Add($"[{dept.Code}] {dept.Name}");
        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("삭제하실 학과를 선택하여주세요.");
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
                    cmbDepartment.Items.Clear();
                    cmbAdvisor.Items.Clear();

                    foreach (var department in departments)
                    {
                        if (department != null)
                        {
                            cmbDepartment.Items.Add(department);
                        }
                    }

                    ResetStudentInfo();
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

        private void btnRegisterProfessor_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();

            if (cmbProfessorDepartment.SelectedIndex < 0)
            {
                MessageBox.Show("학과를 선택해주세요.");
                cmbProfessorDepartment.Focus();
                return;
            }

            prof.DepartmentCode = ((Department)cmbProfessorDepartment.SelectedItem).Code;
            prof.Number = tbxProfessorNumber.Text;
            prof.Name = tbxProfessorName.Text;

            //학과코드랑 이름이 비어있으면 안됨(과제)
            if (prof.DepartmentCode == "" || prof.Number == "" || prof.Name == "")
            {
                if (prof.DepartmentCode == "")
                {
                    MessageBox.Show("학과 코드가 비어있습니다.");
                    cmbProfessorDepartment.Focus();
                }
                else if (prof.Number == "")
                {
                    MessageBox.Show("번호가 비어있습니다.");
                    tbxProfessorNumber.Focus();
                }
                else if (prof.Name == "")
                {
                    MessageBox.Show("이름이 비어있습니다.");
                    tbxProfessorName.Focus();
                }
                else
                {
                    MessageBox.Show("학과 코드와 번호, 이름이 비어있습니다.");
                    tbxProfessorNumber.Focus();
                }

                return;

            }

            if (professors.Count <= 0)
            {
                professors.Add(prof);
                lbxProfessor.Items.Add(prof);

                return;
            }

            for (int i = 0; i < professors.Count; ++i)
            {
                if (professors[i] != null && professors[i].Number == tbxProfessorNumber.Text)
                {
                    MessageBox.Show("이미 등록되어있는 교수입니다.");

                    return;
                }
            }

            professors.Add(prof);

            lbxProfessor.Items.Add(prof);
        }

        private void btnRemoveProfessor_Click(object sender, EventArgs e)
        {
            if (lbxProfessor.SelectedIndex < 0)
            {
                MessageBox.Show("삭제하실 교수를 선택하여주세요.");
                return;
            }

            //is 연산자, 타입 확인용으로 사용
            if (lbxProfessor.SelectedItem is Professor)
            {
                var target = (Professor)lbxProfessor.SelectedItem;

                for (int i = 0; i < professors.Count; ++i)
                {
                    if (professors[i] == target)
                    {
                        professors.Remove(target);
                        break;
                    }
                }

                lbxProfessor.Items.Remove(target);

                //선택 해제
                lbxProfessor.SelectedIndex = -1;
            }
        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbAdvisor.Items.Clear();

            var department = cmbDepartment.SelectedItem as Department;

            if (department == null || cmbDepartment.SelectedIndex < 0)
            {
                return;
            }

            foreach (var professor in professors)
            {
                if (professor != null && professor.DepartmentCode == department.Code)
                {
                    cmbAdvisor.Items.Add(professor.Name);
                }
            }

            cmbAdvisor.SelectedIndex = -1;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ResetStudentInfo();
        }

        private void ResetStudentInfo()
        {
            tbxNumber.Text = "20";
            tbxBirthYear.Text = "20";

            tbxName.Text = "";
            tbxBirthMonth.Text = "";
            tbxBirthDay.Text = "";
            tbxAddress.Text = "";
            tbxContact.Text = "";

            cmbDepartment.SelectedIndex = -1;
            cmbAdvisor.SelectedIndex = -1;
            cmbYear.SelectedIndex = -1;
            cmbClass.SelectedIndex = -1;
            cmbRegStatus.SelectedIndex = -1;
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
            {
                registerStudent();
            } else
            {
                //call
                UpdateStudent();
            }
        }

        private void registerStudent()
        {
            var number = tbxNumber.Text.Trim();

            //딕셔너리를 사용할 때 가장 많이 활용하는 방법
            if (students.ContainsKey(number))
            {
                MessageBox.Show("이미 등록되어 있는 학번입니다.");
                tbxNumber.Focus();
                return;
            }

            Student student = new Student();
            int birthYear, birthMonth;//, birthDay;

            if (int.TryParse(tbxBirthYear.Text, out birthYear)) {

            }
            else
            {
                MessageBox.Show("비정상적인 년도 값입니다.");
                return;
            }
            
            if (int.TryParse(tbxBirthMonth.Text, out birthMonth))
            {

            }
            else
            {
                MessageBox.Show("비정상적인 월 값입니다.");
                return;
            }

            //2022버전 이상 만 지원
            if (int.TryParse(tbxBirthDay.Text, out int birthDay))
            {

            }
            else
            {
                MessageBox.Show("비정상적인 일 값입니다.");
                return;
            }

            student.Number = number;
            student.Name = tbxName.Text.Trim();
            //현재 시스템 시간DateTime.Now();
            student.BirthInfo = new DateTime(birthYear, birthMonth, birthDay);

            if (cmbDepartment.SelectedIndex < 0)
            {
                student.DepartmentCode = null;
            }
            else
            {
                //cmb의 selectedItem은 Object Type이기에 Department type으로 원복해야 함
                student.DepartmentCode = (cmbDepartment.SelectedItem as Department).Code;
            }

            //기본적인 딕셔러니 데이터 삽입 방법, 중복시 덮어쓰기
            students[number] = student;
            //Add방식, 중복시 에러발생
            //students.Add(number, student);

            lbxDictionary.Items.Add(student);
        }

        //define
        private void UpdateStudent()
        {
            //kadai
            throw new NotImplementedException();
        }

        private void lbxDictionary_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedStudent = (lbxDictionary.SelectedItem as Student);

            //강제 호출시
            btnNew_Click(sender, EventArgs.Empty);

            if (selectedStudent != null)
            {
                DisplaySelectedStudent(selectedStudent);
            }
        }

        private void DisplaySelectedStudent(Student student)
        {
            tbxNumber.ReadOnly = true;
            tbxNumber.Text = student.Number;
            tbxBirthYear.Text = student.BirthInfo.Year.ToString();
            
        }

        private void btnTestSearchStudent_Click(object sender, EventArgs e)
        {
            selectedStudent = searchStudentByNumber(tbxTestNumber.Text.Trim());
        }

        private Student searchStudentByNumber(string number)
        {
            if (students.ContainsKey(number))
            {
                return students[number];
            }
            else
            {
                return null;
            }
        }
    }
}
