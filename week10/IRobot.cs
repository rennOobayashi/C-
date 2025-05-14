using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    interface IRobot
    {
        //only public

        //자동 구현 프로퍼티 아님(프로퍼티 헤드)
        /*public*/ int BattaryLevel { get; set; }

        void Charge();
    }
}
