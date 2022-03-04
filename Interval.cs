using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxiBolt
{
    public static  class Interval
    {
        public static  int calcInterval(double commonAmount)
        {
            int driverMoney;
            if (commonAmount <= 45)
            {
                driverMoney = 0;
            }
            else if (commonAmount <= 55)
            {
                driverMoney = 10;
            }
            else if (commonAmount <= 60)
            {
                driverMoney = 12;
            }
            else if (commonAmount <= 70)
            {
                driverMoney = 15;
            }
            else if (commonAmount <= 80)
            {
                driverMoney = 18;
            }
            else if (commonAmount <= 90)
            {
                driverMoney = 20;
            }
            else if (commonAmount <= 100)
            {
                driverMoney = 25;
            }
            else if (commonAmount <= 110)
            {
                driverMoney = 30;
            }
            else
            {
                driverMoney = 35;
            }
            return driverMoney;
        }
    }
}
