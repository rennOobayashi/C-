using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    //열거형의 원래 정체는 정수형
    enum YEAR
    {
        //아무 값도 넣지 않으면 자동으로 0부터 들어감
        ONE = 0, 
        TWO,
        THREE,
        FOUR,
        
        END,
    }

    enum CLASS
    {
        A = 0,
        B,
        C,

        END,
    }

    class Student {
        public static Dictionary<YEAR, string> YearName = new Dictionary<YEAR, string>
        {
            { YEAR.ONE,   "1학년" },
            { YEAR.TWO,   "2학년" },
            { YEAR.THREE, "3학년" },
            { YEAR.FOUR,  "4학년(심화)" },
        };

        public string Number { get; private set; } //학번
        public string Name { get; private set; } //이름
        public DateTime BirthInfo { get; private set; } //생년월일

        public string DepartmentCode { get; set; } //학과코드
        public string AdvisorNumber { get; set; } //지도교수번호
        public YEAR Year { get; set; } // 학년
        public CLASS Class { get; set; }// 반
        public string RegStatus { get; set; }//재적상태
        public string Address { get; set; }//주소

        public Student(string number, string name)
        {
            Number = number;
            Name = name;
        }

        public void SetBirthInfo(int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }

        //자동 구현 프로퍼티
        //컴파일러가 알아서 private 변수(__contact) 만들고
        //get, set 구현
        public string Contact { get; set; }//연락처
        
        public override string ToString() {
            return $"[{this.Number}]{this.Name}";
        }
    }
}
