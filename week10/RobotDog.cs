using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class RobotDog : Dog, IRobot
    {
        private int _batteryLevel;
        public int BatteryLevel 
        {
            get
            {
                return _batteryLevel;
            }
            set
            {
                if (value > 1000)
                {
                    _batteryLevel = 1000;
                }
                else
                {
                    _batteryLevel = value;
                }
            }
        }
        public RobotDog(string name, COLOR color, int year) : base(name, color, year) { }

        public void Charge()
        {
            BatteryLevel = 1000;
        }

        public override string ToString()
        {
            return $"ROBOTDOG:{Name}";
        }
    }
}
