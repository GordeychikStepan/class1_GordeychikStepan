using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Tel
    {
        public int dayTalked;
        public double talkingTime;
        public double talkingCost;
        public double CalculateSum()
        {
            double finalPrice = talkingTime * talkingCost;
            if (dayTalked == 6 || dayTalked == 7)
                return finalPrice - finalPrice * 0.1;
            else return finalPrice;
        }
    }
}
