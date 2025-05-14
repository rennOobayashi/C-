using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    abstract class Animal
    {
        private string _name;
        protected int _level;
        protected COLOR _color;

        public string Name { get { return _name; } }
        public int Level { get { return _level; } }
        public COLOR Color { get { return _color; } }

        public Animal(string name, COLOR color)
        {
            _name = name;
            _color = color;
        }

        //추상 클래스만 가능(하위 클래스에서 반드시 구현해야 함)
        abstract protected bool AddLevel(int level);

        //가상 메소드로 만들어 overriding 가능하게 함
        public virtual void Eat()
        {
            AddLevel(5);
        }

        public void Play()
        {
            AddLevel(3);
        }

        public override string ToString()
        {
            return $"ANIMAL:{_name}";
        }
    }
}
