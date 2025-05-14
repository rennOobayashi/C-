using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Cat
    {
        private string _name;
        private int _level;
        private COLOR _color;

        public string Name { get { return _name; } }
        public int Level { get { return _level; } }
        public COLOR Color { get { return _color; } }

        public Cat(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        private bool AddLevel(int level)
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

        public string Meow(int cnt)
        {
            string retValue = "";

            for (int i = 0; i < cnt; ++i)
            {
                retValue += "Nyann!\r\n";
            }

            return retValue;
        }

        public void Eat()
        {
            AddLevel(3);
        }

        public void Play()
        {
            AddLevel(2);
        }

        public override string ToString()
        {
            return $"CAT:{_name}";
        }
    }
}
