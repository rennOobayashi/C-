using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04Homework
{
    class Grade
    {
        //static field
        public static int MAX_GRADE_COUNT = 9;

        //instance field
        public string StudentNumber;
        public List<double> Scores = new List<double>();
    }
}
