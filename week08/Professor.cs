using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Professor
    {
        public string DepartmentCode;
        public string Number;
        private string _name;

        public string Name 
        {
            get 
            {
                return _name;
            }

            set 
            {
                _name = value;
            }
        }

        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }
    }
}
