using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooApp
{

    class Dog : Animal
    {
        //부모 것을 접근 못해 그대로 사용 가능
        //private string _name;
        //private int _level;

        //부모 것에 접근은 하나 나만의 것을 새로 만들 때
        //private new COLOR _color;

        //부모에게 없음
        private int _year;

        //public string Name { get { return _name; } }
        //public int Level { get { return _level; } }
        //public COLOR Color { get { return _color; } }
        public int Year { get { return _year; } }

        public Dog(string name, COLOR color, int year) : base(name, color)
        {
            _year = year;
        }

        public string Bark(int cnt)
        {
            string retValue = "";

            for (int i = 0; i < cnt; ++i)
            {
                retValue += "Wann!\r\n";
            }

            return retValue;
        }

        //overriding
        public override void Eat()
        {
            AddLevel(3);
        }

        //hiding(new는 컴파일러에 의해 자동으로 추가됨)
        public void Play()
        {
            AddLevel(2);
        }

        protected override bool AddLevel(int level)
        {
            if (_level + level <= 100)
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 100;
                return false;
            }
        }

        //Object class no ToString() wo override.
        public override string ToString()
        {
            return $"DOG:{Name}";
        }
    }
}
