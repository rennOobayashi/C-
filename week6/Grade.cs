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
        //public static int MAX_GRADE_COUNT = 9;
        //private static int MAX_GRADE_COUNT = 9;
        //정적 스태틱 변수(C#의 const = const + static)
        public const int MAX_GRADE_COUNT = 9;

        //instance field
        public string StudentNumber;
#if false
        public List<double> Scores = new List<double>();
#else
        private List<double> _scores = new List<double>();
        public int Count()
        {
            return _scores.Count;
        }

        public double Get(int index)
        {
            return _scores[index];
        }

        public void Clear()
        {
            _scores.Clear();
        }

        public bool Add(double score)
        {
            //static은 instance의 것이 아닌 class의 것
            //if (_scores.Count < this.MAX_GRADE_COUNT)
            if (_scores.Count < Grade.MAX_GRADE_COUNT)
            {
                _scores.Add(score);
                return true;
            }
            else
            {
                return false;
            }
        }
#endif

        //instance method
        public double Average()
        {
#if false
            if (this.Scores.Count == 0)
            {
                return -1;
            }

            double sum = 0;

            foreach (double score in this.Scores)
            {
                sum += score;
            }

            return sum / this.Scores.Count;
#else
            if (this._scores.Count == 0)
            {
                return -1;
            }

            return _scores.Average();
            //return _scores.Sum() / _scores.Count;
#endif
        }

    }
}
